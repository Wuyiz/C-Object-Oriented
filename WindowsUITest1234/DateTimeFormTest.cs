using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace WindowsUITest1234
{
    /// <summary>
    /// CodedUITest1 的摘要说明
    /// </summary>
    [CodedUITest]
    public class DateTimeFormTest
    {
        public DateTimeFormTest()
        {
        }

        [TestMethod]
        [DataSource("DateTimeWeekDataSource")]
        public void TestWeek()
        {

            // 若要为此测试生成代码，请从快捷菜单中选择“为编码的 UI 测试生成代码”，然后选择菜单项之一。
            this.UIMap.RecordedInputDateParams.UITxtYearEditText = TestContext.DataRow["year"].ToString();
            this.UIMap.RecordedInputDateParams.UITxtMonthEditText = TestContext.DataRow["month"].ToString();
            this.UIMap.RecordedInputDateParams.UITxtDayEditText = TestContext.DataRow["day"].ToString();
            this.UIMap.RecordedInputDate();
            string result= TestContext.DataRow["result"].ToString();
            //直接使用抛异常
            //this.UIMap.Assert年月日ExpectedValues.UI请在年月日中输入数字TextDisplayText = result;
            //this.UIMap.Assert年月日();

            //解决方法2：删除Name属性，不作为搜索条件
            this.UIMap.AssertInputDateExpectedValues.UI请在年月日中输入数字TextDisplayText = result;
            this.UIMap.AssertInputDate();
            //解决方法1：为每种情况添加一个断言，分别调用
            //string no= TestContext.DataRow["no"].ToString();
            //if (no == "合法日期")
            //{
            //    this.UIMap.Assert合法日期();
            //}
            //else if (no == "年月日")
            //{
            //    this.UIMap.Assert年月日();
            //}
            //else
            //{
            //    this.UIMap.AssertMonday();
            //}

        }

        [TestMethod]
        [DataSource("DateTimeWeekDataSource")]
        public void TestDate()
        {
            // 若要为此测试生成代码，请从快捷菜单中选择“为编码的 UI 测试生成代码”，然后选择菜单项之一。
            this.UIMap.RecordedInputDate_DaysParams.UITxtYearEditText = TestContext.DataRow["year"].ToString();
            this.UIMap.RecordedInputDate_DaysParams.UITxtMonthEditText = TestContext.DataRow["month"].ToString();
            this.UIMap.RecordedInputDate_DaysParams.UITxtDayEditText = TestContext.DataRow["day"].ToString();
            this.UIMap.RecordedInputDate_Days();
            this.UIMap.AssertInputDate_DaysExpectedValues.UI请在年月日中输入数字TextDisplayText= TestContext.DataRow["result"].ToString();
            this.UIMap.AssertInputDate_Days();

        }
        [TestMethod]
        [DataSource("DateTimeSpanDataSource")]
        public void TestDate1()
        {
            // 若要为此测试生成代码，请从快捷菜单中选择“为编码的 UI 测试生成代码”，然后选择菜单项之一。
            this.UIMap.RecordedInputDate_Days1Params.UITxtYearEditText = TestContext.DataRow["year"].ToString();
            this.UIMap.RecordedInputDate_Days1Params.UITxtMonthEditText = TestContext.DataRow["month"].ToString();
            this.UIMap.RecordedInputDate_Days1Params.UITxtDayEditText = TestContext.DataRow["day"].ToString();
            this.UIMap.RecordedInputDate_Days1Params.UITxtSpanEditText = TestContext.DataRow["span"].ToString();
            this.UIMap.RecordedInputDate_Days1();
            this.UIMap.AssertInputDate_Days1ExpectedValues.UIItem2019年3月26日星期二TextDisplayText = TestContext.DataRow["result"].ToString();
            //断言中使用包含（日期的长格式与操作系统的设置有关，可能不显示星期）
            this.UIMap.AssertInputDate_Days1();

        }

        #region 附加测试特性

        // 编写测试时，可以使用以下附加特性: 

        ////运行每项测试之前使用 TestInitialize 运行代码 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // 若要为此测试生成代码，请从快捷菜单中选择“为编码的 UI 测试生成代码”，然后选择菜单项之一。
        //}

        ////运行每项测试之后使用 TestCleanup 运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // 若要为此测试生成代码，请从快捷菜单中选择“为编码的 UI 测试生成代码”，然后选择菜单项之一。
        //}

        #endregion

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
