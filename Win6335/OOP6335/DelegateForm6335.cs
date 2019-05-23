/**                                                                          
 *          .,:,,,                                        .::,,,::.          
 *        .::::,,;;,                                  .,;;:,,....:i:         
 *        :i,.::::,;i:.      ....,,:::::::::,....   .;i:,.  ......;i.        
 *        :;..:::;::::i;,,:::;:,,,,,,,,,,..,.,,:::iri:. .,:irsr:,.;i.        
 *        ;;..,::::;;;;ri,,,.                    ..,,:;s1s1ssrr;,.;r,        
 *        :;. ,::;ii;:,     . ...................     .;iirri;;;,,;i,        
 *        ,i. .;ri:.   ... ............................  .,,:;:,,,;i:        
 *        :s,.;r:... ....................................... .::;::s;        
 *        ,1r::. .............,,,.,,:,,........................,;iir;        
 *        ,s;...........     ..::.,;:,,.          ...............,;1s        
 *       :i,..,.              .,:,,::,.          .......... .......;1,       
 *      ir,....:rrssr;:,       ,,.,::.     .r5S9989398G95hr;. ....,.:s,      
 *     ;r,..,s9855513XHAG3i   .,,,,,,,.  ,S931,.,,.;s;s&BHHA8s.,..,..:r:     
 *    :r;..rGGh,  :SAG;;G@BS:.,,,,,,,,,.r83:      hHH1sXMBHHHM3..,,,,.ir.    
 *   ,si,.1GS,   sBMAAX&MBMB5,,,,,,:,,.:&8       3@HXHBMBHBBH#X,.,,,,,,rr    
 *   ;1:,,SH:   .A@&&B#&8H#BS,,,,,,,,,.,5XS,     3@MHABM&59M#As..,,,,:,is,   
 *  .rr,,,;9&1   hBHHBB&8AMGr,,,,,,,,,,,:h&&9s;   r9&BMHBHMB9:  . .,,,,;ri.  
 *  :1:....:5&XSi;r8BMBHHA9r:,......,,,,:ii19GG88899XHHH&GSr.      ...,:rs. 
 *  ;s.     .:sS8G8GG889hi.        ....,,:;:,.:irssrriii:,.        ...,,i1,  
 *  ;1,         ..,....,,isssi;,        .,,.                      ....,.i1,  
 *  ;h:               i9HHBMBBHAX9:         .                     ...,,,rs,   狗头在此，bug退散
 *  ,1i..            :A#MBBBBMHB##s                             ....,,,;si.   
 *  .r1,..        ,..;3BMBBBHBB#Bh.     ..                    ....,,,,,i1;   
 *   :h;..       .,..;,1XBMMMMBXs,.,, .. :: ,.               ....,,,,,,ss.   
 *    ih: ..    .;;;, ;;:s58A3i,..    ,. ,.:,,.             ...,,,,,:,s1,    
 *    .s1,....   .,;sh,  ,iSAXs;.    ,.  ,,.i85            ...,,,,,,:i1;     
 *     .rh: ...     rXG9XBBM#M#MHAX3hss13&&HHXr         .....,,,,,,,ih;      
 *      .s5: .....    i598X&&A&AAAAAA&XG851r:       ........,,,,:,,sh;       
 *      . ihr, ...  .         ..                    ........,,,,,;11:.       
 *         ,s1i. ...  ..,,,..,,,.,,.,,.,..       ........,,.,,.;s5i.         
 *          .:s1r,......................       ..............;shs,           
 *          . .:shr:.  ....                 ..............,ishs.             
 *              .,issr;,... ...........................,is1s;.               
 *                 .,is1si;:,....................,:;ir1sr;,                  
 *                    ..:isssssrrii;::::::;;iirsssssr;:..                    
 *                         .,::iiirsssssssssrri;;:.                      
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library6335;
/**    
 * As I write this code, only God and I understood it is doing.
 * But now, only God knows
 */
namespace Win6335.OOP6335 {
    public partial class DelegateForm6335 : Form {
        public DelegateForm6335() {
            InitializeComponent();
            BuildStudents6335();
            dataGridView1.DataSource = Students;
        }

        private List<Student6335> Students;

        public List<Student6335> BuildStudents6335() {
            Students = new List<Student6335>() {
                new Student6335{ Name="张三", ID="101", Score=430, Source="三明" },
                new Student6335{ Name="李四", ID="102", Score=625, Source="福州" },
                new Student6335{ Name="王麻子", ID="109", Score=421, Source="三明" },
                new Student6335{ Name="李狗蛋", ID="106", Score=336, Source="厦门" },
                new Student6335{ Name="李一田", ID="105", Score=456, Source="长乐" },
                new Student6335{ Name="刘莉莉", ID="109", Score=407, Source="长乐" },
                new Student6335{ Name="林保", ID="107", Score=388, Source="厦门" },
                new Student6335{ Name="林书浩", ID="108", Score=298, Source="三明" },
                new Student6335{ Name="李玲", ID="115", Score=567, Source="厦门" },
                new Student6335{ Name="张主强", ID="010", Score=666, Source="泉州" },
                new Student6335{ Name="陈红", ID="110", Score=449, Source="三明" },
                new Student6335{ Name="杨宇箫", ID="112", Score=250, Source="福州" },
                new Student6335{ Name="陈远军", ID="123", Score=456, Source="泉州" },
                new Student6335{ Name="林锃寒", ID="233", Score=478, Source="长乐" },
                new Student6335{ Name="田晋中", ID="120", Score=521, Source="福州" },
            };
            return Students;
        }

        /// <summary>
        /// Button：按学号排序
        /// 调用提供的无参数Sort方法
        /// 按List<T>按学生编号排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbID_CheckedChanged(object sender, EventArgs e) {
            label1.Text = "按学号排序，输出所有属性：";

            List<Student6335> info = Students;
            Action<Student6335> result_ID =
                res => listBox1.Items.Add(res);

            listBox1.DataSource = null;
            listBox1.Items.Clear();

            info.Sort();
            info.ForEach(result_ID);
        }

        /// <summary>
        /// Define the SortByName method that is compatible with delegate Comparison<T>
        /// Implement sort by name
        /// </summary>
        /// <param name="x">Accept the incoming Student6335 object</param>
        /// <param name="y">Accept the incoming Student6335 object</param>
        /// <returns>返回比较结果</returns>
        public static int SortByName(Student6335 x, Student6335 y) {
            return string.Compare(x.Name, y.Name);
        }

        /// <summary>
        /// Button：按姓名排序
        /// 使用List<T>的Sort(Comparison<T>)方法进行排序
        /// 定义与委托匹配的方法作为sort方法的参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbName_CheckedChanged(object sender, EventArgs e) {
            label1.Text = "按姓名排序,列出学号、姓名：";

            List<Student6335> info = Students;
            Action<Student6335> result_Name =
                res => listBox1.Items.Add($"{res.ID}\t{res.Name}");
            Comparison<Student6335> stu_SortByName = SortByName;

            listBox1.DataSource = null;
            listBox1.Items.Clear();

            info.Sort(stu_SortByName);
            info.ForEach(result_Name);
        }

        /// <summary>
        /// Button：按成绩排序
        /// 使用List<T>的Sort(Comparison<T>)方法进行排序
        /// 使用匿名方法为sort方法的参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbScore_CheckedChanged(object sender, EventArgs e) {
            label1.Text = "按成绩排序，列出学号，姓名，成绩：";

            List<Student6335> info = Students;
            Action<Student6335> result_Score =
                res => listBox1.Items.Add($"{res.ID}\t{res.Name}\t{res.Score}");

            listBox1.DataSource = null;
            listBox1.Items.Clear();

            //匿名方法作为sort方法的参数
            info.Sort(
                delegate (Student6335 x, Student6335 y) {
                    return x.Score - y.Score;
                });
            info.ForEach(result_Score);
        }

        /// <summary>
        /// Button：按生源地排序
        /// 使用List<T>的Sort(Comparison<T>)方法进行排序
        /// 使用Lambda表达式作为sort方法的参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbSource_CheckedChanged(object sender, EventArgs e) {
            label1.Text = "按生源地排序，列出学号、姓名、生源地：";

            List<Student6335> info = Students;
            Action<Student6335> result_Source =
                res => listBox1.Items.Add($"{res.ID}\t{res.Name}\t{res.Source}");

            listBox1.DataSource = null;
            listBox1.Items.Clear();

            //用Lambda表达式作为sort方法的参数
            info.Sort((x, y) => {
                return string.Compare(x.Source, y.Source);
            });
            info.ForEach(result_Source);
        }

        /// <summary>
        /// Define a method that matches the delegate as a parameter to the FindAll method
        /// Whether the surname of the judgment object is "Li"
        /// </summary>
        /// <param name="stu">Accept the incoming Student6335 object</param>
        /// <returns>Return bool value</returns>
        public static bool FindByName6335(Student6335 stu) {
            return stu.Name.StartsWith("李");
        }

        /// <summary>
        /// Button：姓李的学生
        /// 使用List<T>的FindAll(Predicate< StudentXXXX >)方法进行查找
        /// 定义与委托匹配的方法作为FindAll方法的参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnList_li_Click(object sender, EventArgs e) {
            label1.Text = "姓李的学生名单:";

            List<Student6335> info = Students.FindAll(FindByName6335);
            Action<Student6335> result_Li =
                res => listBox1.Items.Add(res);

            listBox1.DataSource = null;
            listBox1.Items.Clear();

            info.ForEach(result_Li);
        }

        /// <summary>
        /// Button：来自厦门的学生
        /// 使用List<T>的FindAll(Predicate< StudentXXXX >)方法进行查找
        /// 使用Lambda表达式作为FindAll方法的参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXiamen_stu_Click(object sender, EventArgs e) {
            label1.Text = "来自厦门的学生:";

            List<Student6335> info = Students.FindAll(a => {
                return a.Source.Equals("厦门");
            });
            Action<Student6335> result_Xiamen_stu =
                res => listBox1.Items.Add(res);

            listBox1.DataSource = null;
            listBox1.Items.Clear();

            info.ForEach(result_Xiamen_stu);
        }

        /// <summary>
        /// Button：400分以上的学生
        /// 使用List<T>的FindAll(Predicate< StudentXXXX >)方法进行查找
        /// 使用匿名方法作为FindAll方法的参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn400_Click(object sender, EventArgs e) {
            label1.Text = "400分以上的名单:";

            List<Student6335> info = Students.FindAll(
                delegate (Student6335 x) {
                    return x.Score > 400;
                });
            Action<Student6335> result_400 =
                res => listBox1.Items.Add(res);

            listBox1.DataSource = null;
            listBox1.Items.Clear();

            info.ForEach(result_400);
        }

        /// <summary>
        /// Button：平均成绩
        /// 使用扩展方法Averge，Lambda作为表达式，对集合中的学生成绩进行统计
        /// 用MessageBox显示结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbAverge_Score_Click(object sender, EventArgs e) {
            label1.Text = "";

            var averge = Students.Average(a => a.Score);

            listBox1.DataSource = null;
            listBox1.Items.Clear();

            MessageBox.Show($"平均成绩：{(int)averge}", "计算", 0);
        }

        /// <summary>
        /// Button：最高分
        /// 使用扩展方法Max，Lambda作为表达式，对集合中的学生成绩进行统计
        /// 用MessageBox显示结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbMax_Score_Click(object sender, EventArgs e) {
            label1.Text = "";

            var max = Students.Max(a => a.Score);

            listBox1.DataSource = null;
            listBox1.Items.Clear();

            MessageBox.Show($"最高分：{max}", "计算", 0);
        }

        /// <summary>
        /// Button：最低分
        /// 使用扩展方法Min，Lambda作为表达式，对集合中的学生成绩进行统计
        /// 用MessageBox显示结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbMin_Score_Click(object sender, EventArgs e) {
            label1.Text = "";

            var min = Students.Min(a => a.Score);

            listBox1.DataSource = null;
            listBox1.Items.Clear();

            MessageBox.Show($"最低分：{min}", "计算", 0);
        }
    }
}
