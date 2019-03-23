/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

public interface From<T>
{
    T From(string table);
}

public interface FromBuilder
    : QueryBuilder
    , Where<WhereBuilder>
    , Select<SelectBuilder>
    , As<FromAsBuilder>
{
}
