﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChikenFIGHT
{
    public partial class Huong_Dan_Choi : Form
    {
        public Huong_Dan_Choi()
        {
            InitializeComponent();
            string s = "Hướng Dẫn Chơi Game Bắn Gà\n\n" +
           "1. Mục tiêu của trò chơi:\n" +
           "- Tiêu diệt hết gà trên màn hình của bạn để quan màn.\n" +
           "- Tránh để gà va chạm với tàu của bạn hoặc đạn của chúng trúng tàu.\n" +
           "2. Cách điều khiển:\n" +
           "- Phím mũi tên: Sử dụng phím mũi tên để di chuyển tàu của bạn lên, xuống, trái hoặc phải.\n" +
           "- Sử dụng chuột để điều khiển tàu\n" +
           "- Phím P: Tạm dừng (Pause) trò chơi nếu bạn muốn nghỉ ngơi.\n" +
           "3. Các vật phẩm hỗ trợ:\n" +
           "- Trong quá trình chơi, có thể sẽ xuất hiện một số vật phẩm hỗ trợ như:\n" +
           "  + Đùi gà: Tiêu diệt 1 con gà bất kì bạn sẽ nhận được thêm máu hoặc tốc độ bắn.\n" +
           "  + Tăng sức mạnh: Giúp tàu của bạn có khả năng chịu đựng được nhiều lần va chạm hơn.\n" +
           "4. Lưu ý khi chơi:\n" +
           "- Hãy chú ý tránh né gà và đạn của chúng. Khi bị gà tấn công hoặc va chạm, bạn sẽ mất máu.\n" +
           "- Mỗi lần tiêu diệt gà, bạn sẽ nhận được điểm. Số điểm sẽ được hiển thị trên màn hình.\n" +
           "- Sau khi kết thúc, điểm số sẽ được hiển thị và bạn có thể chọn biểu tượng 'Restart' để bắt đầu lại từ đầu hoặc 'Close' để kết thúc trò chơi.\n\n" +
           "Chúc bạn chơi vui vẻ và đạt điểm cao nhất!";


            ruleGame.Text = s;
            
        }
        private void Huong_Dan_Choi_Load(object sender, EventArgs e)
        {
            // Có thể để trống hoặc thực hiện các hành động cần thiết khi form được tải
        }

        private void ruleGame_Click(object sender, EventArgs e)
        {
            
        }
    }
}