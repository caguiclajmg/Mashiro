/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;

public interface Insert<T>
{
    T Insert(string field, string value);
    T Insert<U>(string field, U value);
    T Insert(IEnumerable<Tuple<string, string>> pairs);
    T Insert<U>(IEnumerable<Tuple<string, U>> pairs);
}

public interface InsertBuilder
    : QueryBuilder
    , Into<IntoBuilder>
{
}
