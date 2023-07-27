using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANG_QUYET_DINH_DINH_CU_UC
{
    public partial class Work : Form
    {
        private Dictionary<string, int> diemTuoiMap = new Dictionary<string, int>();
        private Dictionary<string, int> diemIELTSMap = new Dictionary<string, int>();
        private Dictionary<string, int> diemHocVanMap = new Dictionary<string, int>();
        private Dictionary<string, int> diemKinhNghiemNgoaiNuocMap = new Dictionary<string, int>();
        private Dictionary<string, int> diemKinhNghiemTrongNuocMap = new Dictionary<string, int>();
        private int diemBangCapDacBiet; // Biến lưu trữ điểm bằng cấp đặc biệt
        private int diemVC; // Biến lưu trữ điểm bằng cấp đặc biệt

        private int diemTong;
        public Work()
        {
            InitializeComponent();
            diemTuoiMap.Add("18 - 24", 25);
            diemTuoiMap.Add("25 - 32", 30);
            diemTuoiMap.Add("33 - 39", 25);
            diemTuoiMap.Add("40 - 44", 15);
            diemTuoiMap.Add("Còn lại", 0);

            diemIELTSMap.Add("Tối thiểu 6.0 IELTS", 0);
            diemIELTSMap.Add("Tối thiểu 7.0 IELTS", 10);
            diemIELTSMap.Add("Tối thiểu 8.0 IELTS", 20);

            diemHocVanMap.Add("Tốt nghiệp Tiến sĩ", 20);
            diemHocVanMap.Add("Tốt nghiệp Cử nhân và Thạc sĩ", 15);
            diemHocVanMap.Add("Tốt nghiệp Cao đẳng hoặc có chứng chỉ nghề tại Úc", 10);
            diemHocVanMap.Add("Có bằng cấp/ chứng chỉ hoặc giải thưởng được công nhận bởi Cơ quan đánh giá thẩm định tay nghề Úc", 10);

            diemKinhNghiemNgoaiNuocMap.Add("Dưới 3 năm", 0);
            diemKinhNghiemNgoaiNuocMap.Add("Từ 3 - 4 năm", 5);
            diemKinhNghiemNgoaiNuocMap.Add("Từ 5 - 7 năm", 10);
            diemKinhNghiemNgoaiNuocMap.Add("Tối thiểu 8 năm", 15);

            diemKinhNghiemTrongNuocMap.Add("Dưới 1 năm", 0);
            diemKinhNghiemTrongNuocMap.Add("Từ 1 - 2 năm", 5);
            diemKinhNghiemTrongNuocMap.Add("Từ 3 - 4 năm", 10);
            diemKinhNghiemTrongNuocMap.Add("Từ 5 - 7 năm", 15);
            diemKinhNghiemTrongNuocMap.Add("Từ 8 năm trở lên", 20);

            diemBangCapDacBiet = 0;
            diemVC = 0;

            // Gán sự kiện CheckedChanged cho RadioButton để xử lý khi người dùng thay đổi lựa chọn
            rd1.CheckedChanged += RadioButton_CheckedChanged;
            rd2.CheckedChanged += RadioButton_CheckedChanged;
            rd7.CheckedChanged += RadioButton_CheckedChanged;
            //Gán sự kiện VC
            rd3.CheckedChanged += RadioButton_CheckedChanged1;
            rd4.CheckedChanged += RadioButton_CheckedChanged1;
            rd5.CheckedChanged += RadioButton_CheckedChanged1;
            rd6.CheckedChanged += RadioButton_CheckedChanged1;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Work_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Cập nhật điểm bằng cấp đặc biệt dựa trên RadioButton đã chọn
            if (rd1.Checked)
            {
                diemBangCapDacBiet = 10;
            }
            else if (rd2.Checked)
            {
                diemBangCapDacBiet = 5;
            }
            else if (rd7.Checked)
            {
                diemBangCapDacBiet = 0;
            }
        }
        private void RadioButton_CheckedChanged1(object sender, EventArgs e)
        {
            // Cập nhật điểm bằng cấp đặc biệt dựa trên RadioButton đã chọn
            if (rd3.Checked)
            {
                diemVC = 10;
            }
            else if (rd4.Checked)
            {
                diemVC = 5;
            }
            else if (rd5.Checked)
            {
                diemVC = 10;
            }
            else if (rd6.Checked)
            {
                diemVC = 0;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            /// Lấy thông tin từ các phần tử giao diện
            string tuoiChon = cbbAge.SelectedItem.ToString();
            string diemIELTSChon = cbbE.SelectedItem.ToString();
            string diemHocVanChon = cbbHV.SelectedItem.ToString();
            string diemKinhNghiemNgoaiNuocChon = cbbNN.SelectedItem.ToString();
            string diemKinhNghiemTrongNuocChon = cbbTU.SelectedItem.ToString();

            // Lấy điểm tương ứng từ từ điển
            int diemTuoi = diemTuoiMap[tuoiChon];
            int diemIELTS = diemIELTSMap[diemIELTSChon];
            int diemHocVan = diemHocVanMap[diemHocVanChon];
            int diemKinhNghiemNgoaiNuoc = diemKinhNghiemNgoaiNuocMap[diemKinhNghiemNgoaiNuocChon];
            int diemKinhNghiemTrongNuoc = diemKinhNghiemTrongNuocMap[diemKinhNghiemTrongNuocChon];

            diemTong = diemTuoi + diemIELTS + diemHocVan + diemKinhNghiemNgoaiNuoc + diemKinhNghiemTrongNuoc + diemBangCapDacBiet + diemVC;

            // Hiển thị kết quả tính điểm
            MessageBox.Show("Tổng điểm: " + diemTong.ToString());

            // Kiểm tra điều kiện nếu diemTong > 65 thì có thể nộp hồ sơ
            if (diemTong > 65)
            {
                MessageBox.Show("Bạn có thể nộp hồ sơ!");
            }
            else
            {
                MessageBox.Show("Bạn không đủ điểm để nộp hồ sơ!");
            }

        }
    }
}
