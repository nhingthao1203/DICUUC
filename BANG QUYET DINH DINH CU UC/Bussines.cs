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
    public partial class Bussines : Form
    {
        private Dictionary<string, int> diemTuoiMap = new Dictionary<string, int>();
        private Dictionary<string, int> diemIELTSMap = new Dictionary<string, int>();
        private Dictionary<string, int> diemKinhNghiemNgoaiNuocMap = new Dictionary<string, int>();
        private Dictionary<string, int> diemKinhNghiemTrongNuocMap = new Dictionary<string, int>();
        private int diemBangCapDacBiet; // Biến lưu trữ điểm bằng cấp đặc biệt
        private int diemVC; // Biến lưu trữ điểm bằng cấp đặc biệt
        private int diemHV;

        private int diemTong;
        public Bussines()
        {
            InitializeComponent();
            diemTuoiMap.Add("18 - 24", 20);
            diemTuoiMap.Add("25 - 32", 30);
            diemTuoiMap.Add("33 - 39", 25);
            diemTuoiMap.Add("40 - 44", 20);
            diemTuoiMap.Add("45 - 54", 15);
            diemTuoiMap.Add("Còn lại", 0);


            diemIELTSMap.Add("Tối thiểu 6.0 IELTS", 0);
            diemIELTSMap.Add("Tối thiểu 7.0 IELTS", 10);
            //diemIELTSMap.Add("Tối thiểu 8.0 IELTS", 20);

            diemKinhNghiemNgoaiNuocMap.Add("Tối thiểu 4 năm trong vòng 5 năm gần nhất", 10);
            diemKinhNghiemNgoaiNuocMap.Add("Tối thiểu 7 năm trong vòng 8 năm gần nhất", 15);


            diemKinhNghiemTrongNuocMap.Add("Tối thiểu 4 năm", 10);
            diemKinhNghiemTrongNuocMap.Add("Tối thiểu 7 năm", 15);

            diemBangCapDacBiet = 0;
            diemVC = 0;
            diemHV = 0;

            // Gán sự kiện CheckedChanged cho RadioButton để xử lý khi người dùng thay đổi lựa chọn
            rd2.CheckedChanged += RadioButton_CheckedChanged;
            rd7.CheckedChanged += RadioButton_CheckedChanged;
            //Gán sự kiện VC
            rd3.CheckedChanged += RadioButton_CheckedChanged1;
            rd4.CheckedChanged += RadioButton_CheckedChanged1;
            rd5.CheckedChanged += RadioButton_CheckedChanged1;
            rd6.CheckedChanged += RadioButton_CheckedChanged1;
            //Gán sự kiện HV
            rb1.CheckedChanged += RadioButton_CheckedChanged2;
            rb2.CheckedChanged += RadioButton_CheckedChanged2;


        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Cập nhật điểm bằng cấp đặc biệt dựa trên RadioButton đã chọn
            if (rd2.Checked)
            {
                diemBangCapDacBiet = 10;
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
        private void RadioButton_CheckedChanged2(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                diemHV = 5;
            }
            else if (rb2.Checked)
            {
                diemHV = 10;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// Lấy thông tin từ các phần tử giao diện
            string tuoiChon = cbbAge.SelectedItem.ToString();
            string diemIELTSChon = cbbE.SelectedItem.ToString();
            string diemKinhNghiemNgoaiNuocChon = cbbNN.SelectedItem.ToString();
            string diemKinhNghiemTrongNuocChon = cbbTU.SelectedItem.ToString();

            // Lấy điểm tương ứng từ từ điển
            int diemTuoi = diemTuoiMap[tuoiChon];
            int diemIELTS = diemIELTSMap[diemIELTSChon];
            int diemKinhNghiemNgoaiNuoc = diemKinhNghiemNgoaiNuocMap[diemKinhNghiemNgoaiNuocChon];
            int diemKinhNghiemTrongNuoc = diemKinhNghiemTrongNuocMap[diemKinhNghiemTrongNuocChon];

            diemTong = diemTuoi + diemIELTS + diemHV + diemKinhNghiemNgoaiNuoc + diemKinhNghiemTrongNuoc + diemBangCapDacBiet + diemVC;

            // Hiển thị kết quả tính điểm
            MessageBox.Show("Tổng điểm: " + diemTong.ToString());
        }
    }
}
