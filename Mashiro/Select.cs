/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System.Collections.Generic;

public interface Select<T>
{
    T Select();
    T Select(IEnumerable<string> fields);
}

public interface SelectBuilder
    : QueryBuilder
    , From<FromBuilder>
    , Distinct<DistinctBuilder>
{
}
