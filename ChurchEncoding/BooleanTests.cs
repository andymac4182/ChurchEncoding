﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Ploeh.Samples.ChurchEncoding
{
    public class BooleanTests
    {
        [Fact]
        public void Example1()
        {
            var actual = new ChurchAnd(new ChurchTrue(), new ChurchFalse());
            Assert.False(actual.ToBool());
        }

        [Fact]
        public void Example2()
        {
            var actual = new ChurchAnd(new ChurchTrue(), new ChurchTrue());
            Assert.True(actual.ToBool());
        }

        [Fact]
        public void Example3()
        {
            var actual =
                new ChurchNot(
                    new ChurchOr(
                        new ChurchFalse(),
                        new ChurchTrue()));
            Assert.False(actual.ToBool());
        }

        [Fact]
        public void StringExample1()
        {
            var b =
                new ChurchOrOfString(
                    new ChurchTrueOfString(),
                    new ChurchFalseOfString());
            var actual = b.Match("foo", "bar");
            Assert.Equal("foo", actual);
        }

        [Fact]
        public void StringExample2()
        {
            var b =
                new ChurchOrOfString(
                    new ChurchFalseOfString(),
                    new ChurchNotOfString(
                        new ChurchTrueOfString()));
            var actual = b.Match("foo", "bar");
            Assert.Equal("bar", actual);
        }

        [Fact]
        public void Int32Example1()
        {
            var b =
                new ChurchOrOfInt32(
                    new ChurchFalseOfInt32(),
                    new ChurchFalseOfInt32());
            var actual = b.Match(42, 1337);
            Assert.Equal(1337, actual);
        }

        [Fact]
        public void Int32Example2()
        {
            var b =
                new ChurchNotOfInt32(
                    new ChurchAndOfInt32(
                        new ChurchTrueOfInt32(),
                        new ChurchFalseOfInt32()));
            var actual = b.Match(42, 1337);
            Assert.Equal(42, actual);
        }
    }
}
