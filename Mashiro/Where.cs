/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;

public enum ComparisonOperator
{
    EqualTo,
    GreaterThan,
    LessThan,
    GreaterThanOrEqualTo,
    LessThanOrEqualTo,
    NotEqualTo
}

public interface Where<T>
{
    T Where(string field, string value, ComparisonOperator comparisonOperator);
    T Where(string field, string value);
    T Where<U>(string field, U value, ComparisonOperator comparisonOperator);
    T Where<U>(string field, U value);
    T Where(IEnumerable<Tuple<string, string>> conditions);
    T Where<U>(IEnumerable<Tuple<string, U>> conditions);
}

public interface WhereBuilder
    : QueryBuilder
{
}
