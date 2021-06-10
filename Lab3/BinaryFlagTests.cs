using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IIG.BinaryFlag;

namespace Lab3
{
    [TestClass]
    public class BinaryFlagTests
    {
        [TestClass]
        public class ConstructorTests
        {
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_2_9(bool initialValue)
            {
                ulong minLength = 2;
                ulong length = minLength - 1;

                new MultipleBinaryFlag(length, initialValue);
            }

            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_3_2_9(bool initialValue)
            {
                ulong maxLength = 17179868704 + 1;
                ulong length = maxLength;

                new MultipleBinaryFlag(length, initialValue);
            }

            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_3_4_5_9(bool initialValue)
            {
                ulong maxLengthUInt = 32;
                ulong length = maxLengthUInt - 1;

                MultipleBinaryFlag flag = new MultipleBinaryFlag(length, initialValue);

                Assert.IsNotNull(flag);
            }

            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_3_4_6_7_9(bool initialValue)
            {
                ulong maxLengthULong = 64;
                ulong length = maxLengthULong - 1;

                MultipleBinaryFlag flag = new MultipleBinaryFlag(length, initialValue);

                Assert.IsNotNull(flag);
            }

            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_3_4_6_8_9(bool initialValue)
            {
                ulong minLengthUIntArray = 65;
                ulong length = minLengthUIntArray;

                MultipleBinaryFlag flag = new MultipleBinaryFlag(length, initialValue);

                Assert.IsNotNull(flag);
            }
        }

        [TestClass]
        public class SetFlagMethodTests
        {
            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_2_3_4_24(bool initialValue)
            {
                try
                {
                    ulong minLengthUInt = 2;
                    ulong index = minLengthUInt - 1;
                    MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthUInt, initialValue);

                    multipleFlag.Dispose();
                    multipleFlag.SetFlag(index);
                    bool? flag = multipleFlag.GetFlag();

                    Assert.IsNull(flag);
                }
                catch (Exception)
                {
                    Assert.Fail();
                }
            }

            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            [TestMethod]
            public void Route_0_1_2_3_5_6_7_24(bool initialValue)
            {
                ulong minLengthUInt = 2;
                ulong index = minLengthUInt;
                MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthUInt, initialValue);

                multipleFlag.SetFlag(index);
            }

            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_2_3_5_6_8_24(bool initialValue)
            {
                try
                {
                    ulong minLengthUInt = 2;
                    ulong index = minLengthUInt - 1;
                    MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthUInt, initialValue);

                    multipleFlag.SetFlag(index);
                }
                catch (Exception)
                {
                    Assert.Fail();
                }
            }

            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_9_10_11_12_24(bool initialValue)
            {
                try
                {
                    ulong minLengthULong = 33;
                    ulong index = minLengthULong - 1;
                    MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthULong, initialValue);

                    multipleFlag.Dispose();
                    multipleFlag.SetFlag(index);
                    bool? flag = multipleFlag.GetFlag();

                    Assert.IsNull(flag);
                }
                catch (Exception)
                {
                    Assert.Fail();
                }
            }

            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_9_10_11_13_14_15_24(bool initialValue)
            {
                ulong minLengthULong = 33;
                ulong index = minLengthULong;
                MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthULong, initialValue);

                multipleFlag.SetFlag(index);
            }

            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_9_10_11_13_14_16_24(bool initialValue)
            {
                try
                {
                    ulong minLengthULong = 33;
                    ulong index = minLengthULong - 1;
                    MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthULong, initialValue);

                    multipleFlag.SetFlag(index);
                }
                catch (Exception)
                {
                    Assert.Fail();
                }
            }

            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_9_17_18_19_24(bool initialValue)
            {
                try
                {
                    ulong minLengthUIntArray = 65;
                    ulong index = minLengthUIntArray - 1;
                    MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthUIntArray, initialValue);

                    multipleFlag.Dispose();
                    multipleFlag.SetFlag(index);
                    bool? flag = multipleFlag.GetFlag();

                    Assert.IsNull(flag);
                }
                catch (Exception)
                {
                    Assert.Fail();
                }
            }

            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_9_17_18_20_21_22_24(bool initialValue)
            {
                ulong minLengthUIntArray = 65;
                ulong index = minLengthUIntArray;
                MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthUIntArray, initialValue);

                multipleFlag.SetFlag(index);
            }

            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_9_17_18_20_21_23_24(bool initialValue)
            {
                try
                {
                    ulong minLengthUIntArray = 65;
                    ulong index = minLengthUIntArray - 1;
                    MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthUIntArray, initialValue);

                    multipleFlag.SetFlag(index);
                }
                catch (Exception)
                {
                    Assert.Fail();
                }
            }
        }

        [TestClass]
        public class GetFlagMethodTests
        {
            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_2_3_4_13(bool initialValue)
            {
                ulong minLengthUInt = 2;
                MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthUInt, initialValue);

                multipleFlag.Dispose();
                bool? flag = multipleFlag.GetFlag();

                Assert.IsNull(flag);
            }

            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_2_3_5_13(bool initialValue)
            {
                ulong minLengthUInt = 2;
                MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthUInt, initialValue);

                bool? flag = multipleFlag.GetFlag();

                Assert.AreEqual(initialValue, flag);
            }

            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_6_7_8_9_13(bool initialValue)
            {
                ulong minLengthULong = 33;
                MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthULong, initialValue);

                multipleFlag.Dispose();
                bool? flag = multipleFlag.GetFlag();

                Assert.IsNull(flag);
            }

            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_6_7_8_10_13(bool initialValue)
            {
                ulong minLengthULong = 33;
                MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthULong, initialValue);

                bool? flag = multipleFlag.GetFlag();

                Assert.AreEqual(initialValue, flag);
            }

            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_6_11_12_13(bool initialValue)
            {
                ulong minLengthUIntArray = 65;
                MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthUIntArray, initialValue);

                bool? flag = multipleFlag.GetFlag();

                Assert.AreEqual(initialValue, flag);
            }
        }

        [TestClass]
        public class ResetFlagMethodTests
        {
            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_2_3_4_24(bool initialValue)
            {
                try
                {
                    ulong minLengthUInt = 2;
                    ulong index = minLengthUInt - 1;
                    MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthUInt, initialValue);

                    multipleFlag.Dispose();
                    multipleFlag.ResetFlag(index);
                    bool? flag = multipleFlag.GetFlag();

                    Assert.IsNull(flag);
                }
                catch (Exception)
                {
                    Assert.Fail();
                }
            }

            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_2_3_5_6_7_24(bool initialValue)
            {
                ulong minLengthUInt = 2;
                MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthUInt, initialValue);

                multipleFlag.ResetFlag(minLengthUInt);
            }

            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_2_3_5_6_8_24(bool initialValue)
            {
                ulong minLengthUInt = 2;
                ulong index = minLengthUInt - 1;
                MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthUInt, initialValue);

                multipleFlag.ResetFlag(index);
                bool? flag = multipleFlag.GetFlag();

                Assert.IsFalse((bool)flag);
            }

            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_9_10_11_12_24(bool initialValue)
            {
                try
                {
                    ulong minLengthULong = 33;
                    ulong index = minLengthULong - 1;
                    MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthULong, initialValue);

                    multipleFlag.Dispose();
                    multipleFlag.ResetFlag(index);
                    bool? flag = multipleFlag.GetFlag();

                    Assert.IsNull(flag);
                }
                catch (Exception)
                {
                    Assert.Fail();
                }
            }

            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_9_10_11_13_14_15_24(bool initialValue)
            {
                ulong minLengthULong = 33;
                MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthULong, initialValue);

                multipleFlag.ResetFlag(minLengthULong);
            }

            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_9_10_11_13_14_16_24(bool initialValue)
            {
                ulong minLengthULong = 33;
                ulong index = minLengthULong - 1;
                MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthULong, initialValue);

                multipleFlag.ResetFlag(index);
                bool? flag = multipleFlag.GetFlag();

                Assert.IsFalse((bool)flag);
            }

            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_9_17_18_19_24(bool initialValue)
            {
                try
                {
                    ulong minLengthUIntArray = 65;
                    ulong index = minLengthUIntArray - 1;
                    MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthUIntArray, initialValue);

                    multipleFlag.Dispose();
                    multipleFlag.ResetFlag(index);
                    bool? flag = multipleFlag.GetFlag();

                    Assert.IsNull(flag);
                }
                catch (Exception)
                {
                    Assert.Fail();
                }
            }

            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_9_17_18_20_21_22_24(bool initialValue)
            {
                ulong minLengthUIntArray = 65;
                MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthUIntArray, initialValue);

                multipleFlag.ResetFlag(minLengthUIntArray);
            }

            [DataTestMethod]
            [DataRow(true)]
            [DataRow(false)]
            public void Route_0_1_9_17_18_20_21_23_24(bool initialValue)
            {
                ulong minLengthUIntArray = 65;
                ulong index = minLengthUIntArray - 1;
                MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(minLengthUIntArray, initialValue);

                multipleFlag.ResetFlag(index);
                bool? flag = multipleFlag.GetFlag();

                Assert.IsFalse((bool)flag);
            }
        }

        [TestClass]
        public class DisposeMethodTests
        {
            [DataTestMethod]
            [DataRow((ulong)2, true)]
            [DataRow((ulong)33, true)]
            [DataRow((ulong)65, true)]
            [DataRow((ulong)2, false)]
            [DataRow((ulong)33, false)]
            [DataRow((ulong)65, false)]
            public void Route_0_1_2_6(ulong length, bool initialValue)
            {
                try
                {
                    MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(length, initialValue);

                    multipleFlag.Dispose();
                    multipleFlag.Dispose();
                }
                catch (Exception)
                {
                    Assert.Fail();
                }
            }

            [DataTestMethod]
            [DataRow((ulong)2, true)]
            [DataRow((ulong)33, true)]
            [DataRow((ulong)65, true)]
            [DataRow((ulong)2, false)]
            [DataRow((ulong)33, false)]
            [DataRow((ulong)65, false)]
            public void Route_0_1_3_4_5_6(ulong length, bool initialValue)
            {
                try
                {
                    MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(length, initialValue);

                    multipleFlag.Dispose();
                }
                catch (Exception)
                {
                    Assert.Fail();
                }
            }
        }
    }
}
