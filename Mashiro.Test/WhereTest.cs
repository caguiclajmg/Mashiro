/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;
using Xunit;

using System.Collections.Generic;

public class WhereTest
{
    [Fact]
    public void Test1()
    {
        Query query = null;
        query.Select(new []{"column"}).From("table").As("A").Build();
    }
}
