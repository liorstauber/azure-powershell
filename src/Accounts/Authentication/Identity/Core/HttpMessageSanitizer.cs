﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------
//
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Microsoft.Azure.PowerShell.Authenticators.Identity.Core
{
    internal class HttpMessageSanitizer
    {
        private const string LogAllValue = "*";
        private readonly bool _logAllHeaders;
        private readonly bool _logFullQueries;
        private readonly string[] _allowedQueryParameters;
        private readonly string _redactedPlaceholder;
        private readonly HashSet<string> _allowedHeaders;

        internal static HttpMessageSanitizer Default = new HttpMessageSanitizer(Array.Empty<string>(), Array.Empty<string>());

        public HttpMessageSanitizer(string[] allowedQueryParameters, string[] allowedHeaders, string redactedPlaceholder = "REDACTED")
        {
            _logAllHeaders = allowedHeaders.Contains(LogAllValue);
            _logFullQueries = allowedQueryParameters.Contains(LogAllValue);

            _allowedQueryParameters = allowedQueryParameters;
            _redactedPlaceholder = redactedPlaceholder;
            _allowedHeaders = new HashSet<string>(allowedHeaders, StringComparer.InvariantCultureIgnoreCase);
        }

        public string SanitizeHeader(string name, string value)
        {
            if (_logAllHeaders || _allowedHeaders.Contains(name))
            {
                return value;
            }

            return _redactedPlaceholder;
        }

        public string SanitizeUrl(string url)
        {
            if (_logFullQueries)
            {
                return url;
            }

#if NET5_0_OR_GREATER
            int indexOfQuerySeparator = url.IndexOf('?', StringComparison.Ordinal);
#else
            int indexOfQuerySeparator = url.IndexOf('?');
#endif

            if (indexOfQuerySeparator == -1)
            {
                return url;
            }

            StringBuilder stringBuilder = new StringBuilder(url.Length);
            stringBuilder.Append(url, 0, indexOfQuerySeparator);

            string query = url.Substring(indexOfQuerySeparator);

            int queryIndex = 1;
            stringBuilder.Append('?');

            do
            {
                int endOfParameterValue = query.IndexOf('&', queryIndex);
                int endOfParameterName = query.IndexOf('=', queryIndex);
                bool noValue = false;

                // Check if we have parameter without value
                if (endOfParameterValue == -1 && endOfParameterName == -1 ||
                    endOfParameterValue != -1 && (endOfParameterName == -1 || endOfParameterName > endOfParameterValue))
                {
                    endOfParameterName = endOfParameterValue;
                    noValue = true;
                }

                if (endOfParameterName == -1)
                {
                    endOfParameterName = query.Length;
                }

                if (endOfParameterValue == -1)
                {
                    endOfParameterValue = query.Length;
                }
                else
                {
                    // include the separator
                    endOfParameterValue++;
                }

                ReadOnlySpan<char> parameterName = query.AsSpan(queryIndex, endOfParameterName - queryIndex);

                bool isAllowed = false;
                foreach (string name in _allowedQueryParameters)
                {
                    if (parameterName.Equals(name.AsSpan(), StringComparison.OrdinalIgnoreCase))
                    {
                        isAllowed = true;
                        break;
                    }
                }

                int valueLength = endOfParameterValue - queryIndex;
                int nameLength = endOfParameterName - queryIndex;

                if (isAllowed)
                {
                    stringBuilder.Append(query, queryIndex, valueLength);
                }
                else
                {
                    if (noValue)
                    {
                        stringBuilder.Append(query, queryIndex, valueLength);
                    }
                    else
                    {
                        stringBuilder.Append(query, queryIndex, nameLength);
                        stringBuilder.Append('=');
                        stringBuilder.Append(_redactedPlaceholder);
                        if (query[endOfParameterValue - 1] == '&')
                        {
                            stringBuilder.Append('&');
                        }
                    }
                }

                queryIndex += valueLength;
            } while (queryIndex < query.Length);

            return stringBuilder.ToString();
        }
    }
}
