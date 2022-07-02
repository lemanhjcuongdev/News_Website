using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace BTL_News_Website
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            List<News> newslist = new List<News>();
            newslist.Add(new News(1,
                "Zalo sẵn sàng thu phí người dùng, hạn chế loạt tính năng miễn phí",
                "Vừa qua, mạng xã hội Zalo cho biết sẽ có nhiều cập nhật quan trọng trên nền tảng này từ ngày 01/08/2022. " +
                "Cụ thể, sẽ có 5 thay đổi quan trọng được tập đoàn thay đổi trên Zalo. " +
                "Đại diện bên phía VNG (công ty chủ quản của Zalo) nhấn mạnh rằng, các thay đổi này có lộ trình từ trước với mục đích nâng cao tính bảo mật và sự riêng tư cho khách hàng. " +
                "Đầu tiên, người lạ sẽ không thể xem hoặc bình luận trên nhật ký của người dùng.Ngoài ra, mỗi tài khoản Zalo giờ đây có 40 lần hiển thị / tháng khi người lạ tìm kiếm qua số điện thoại. " +
                "Bên cạnh đó, mỗi tài khoản chỉ được phản hồi 40 hội thoại / tháng từ người lạ.Thêm nữa, danh bạ sẽ chứa tối đa 1.000 liên hệ, tài khoản thường không được sử dụng username, mỗi tài khoản chỉ có 5 tin nhắn nhanh, nếu người dùng muốn thêm mới thì buộc phải xóa bớt tin nhắn nhanh cũ. " +
                "So với dịch vụ ban đầu, các tính năng phổ biến của Zalo sẽ bị giới hạn khá nhiều. Trước đó, Zalo đã triển khai Gói dịch vụ trả phí với Zalo OA doanh nghiệp(bắt đầu từ ngày 22/6). " +
                "Các tính năng hỗ trợ doanh nghiệp là một phần của các gói sau: gói dùng thử(10.000 đồng), nâng cao(59.000 đồng), Premium(399.000 đồng). " +
                "Các tính năng hỗ trợ công việc kinh doanh bao gồm nhận diện thương hiệu, chatbot, tích hợp API, lượt tương tác nâng cao… " +
                "Hiện tại, Zalo đang là một trong những ứng dụng được nhiều người dùng tại Việt Nam sử dụng để liên lạc trực tuyến.Ước tính, có khoảng 70 triệu tài khoản đang hoạt động tại Việt Nam. " +
                "Trong năm 2021, 620 tỷ tin nhắn và có 52 tỷ phút gọi video được thực hiện qua Zalo.Những con số cho thấy người dùng phụ thuộc lớn vào ứng dụng này.","2022-06-29","Khoa học & Công nghệ", "asset/images/Zalo1.jpg","#"));
            newslist.Add(new News(2,
                "Sau nhiều ngày tăng 'sốc', giá xăng chiều nay giảm 110 - 410 đồng/lít",
                "Liên Bộ Tài chính, Bộ Công Thương vừa thay đổi giá bán lẻ xăng dầu trong kỳ điều chỉnh hôm nay (1/7). " +
                "Thời gian áp dụng bắt đầu từ 15h. " +
                "Theo đó, tại đợt điều chỉnh này, xăng E5 RON 92 giảm 410 đồng / lít; xăng RON 95 giảm 110 đồng / lít." +
                "Các loại dầu cũng giảm giá." +
                "Cụ thể, giá dầu diesel giảm 400 đồng / lít, dầu hỏa 430 đồng / lít; dầu mazut giảm 1.010 đồng / kg." +
                "Sau nhiều ngày tăng sốc, giá xăng chiều nay giảm 110 - 410 đồng / lít - 1. " +
                "Sau điều chỉnh, giá xăng E5 RON 92 tối đa là 30.890 đồng / lít; RON 95 là 32.760 đồng / lít; dầu diesel là 29.610 đồng / lít, dầu hỏa là 28.350 đồng / lít, dầu mazut là 19.720 đồng / kg. " +
                "Tại kỳ điều hành này, Liên Bộ không chi quỹ bình ổn với xăng dầu, trích lập quỹ đối với xăng E5 RON 92 là 100 đồng / lít và dầu hỏa 300 đồng / lít, mazut 800 đồng / kg. " +
                "Như vậy, giá xăng dầu đã có lần đầu giảm giá sau chuỗi tăng 7 lần liên tiếp." +
                "Tuy nhiên, do mức giảm khá nhẹ nên giá cả mặt hàng hóa này vẫn ở mức rất cao. " +
                "Để hạ nhiệt giá xăng dầu, Bộ Tài chính đã đưa giải pháp giảm thuế bảo vệ môi trường. " +
                "Mới đây, Bộ Tài chính đã trình thêm phương án giảm thêm thuế tiêu thụ đặc biệt và VAT để kìm giá xăng.", "2022-07-01", "Xã hội", "asset/images/xang.jpg","#"));
            newslist.Add(new News(3,
                "Sau nhiều ngày tăng 'sốc', giá xăng chiều nay giảm 110 - 410 đồng/lít",
                "Liên Bộ Tài chính, Bộ Công Thương vừa thay đổi giá bán lẻ xăng dầu trong kỳ điều chỉnh hôm nay (1/7). " +
                "Thời gian áp dụng bắt đầu từ 15h. " +
                "Theo đó, tại đợt điều chỉnh này, xăng E5 RON 92 giảm 410 đồng / lít; xăng RON 95 giảm 110 đồng / lít." +
                "Các loại dầu cũng giảm giá." +
                "Cụ thể, giá dầu diesel giảm 400 đồng / lít, dầu hỏa 430 đồng / lít; dầu mazut giảm 1.010 đồng / kg." +
                "Sau nhiều ngày tăng sốc, giá xăng chiều nay giảm 110 - 410 đồng / lít - 1. " +
                "Sau điều chỉnh, giá xăng E5 RON 92 tối đa là 30.890 đồng / lít; RON 95 là 32.760 đồng / lít; dầu diesel là 29.610 đồng / lít, dầu hỏa là 28.350 đồng / lít, dầu mazut là 19.720 đồng / kg. " +
                "Tại kỳ điều hành này, Liên Bộ không chi quỹ bình ổn với xăng dầu, trích lập quỹ đối với xăng E5 RON 92 là 100 đồng / lít và dầu hỏa 300 đồng / lít, mazut 800 đồng / kg. " +
                "Như vậy, giá xăng dầu đã có lần đầu giảm giá sau chuỗi tăng 7 lần liên tiếp." +
                "Tuy nhiên, do mức giảm khá nhẹ nên giá cả mặt hàng hóa này vẫn ở mức rất cao. " +
                "Để hạ nhiệt giá xăng dầu, Bộ Tài chính đã đưa giải pháp giảm thuế bảo vệ môi trường. " +
                "Mới đây, Bộ Tài chính đã trình thêm phương án giảm thêm thuế tiêu thụ đặc biệt và VAT để kìm giá xăng.", "2022-07-01", "Xã hội", "asset/images/xang.jpg", "#"));
            newslist.Add(new News(4,
                "Sau nhiều ngày tăng 'sốc', giá xăng chiều nay giảm 110 - 410 đồng/lít",
                "Liên Bộ Tài chính, Bộ Công Thương vừa thay đổi giá bán lẻ xăng dầu trong kỳ điều chỉnh hôm nay (1/7). " +
                "Thời gian áp dụng bắt đầu từ 15h. " +
                "Theo đó, tại đợt điều chỉnh này, xăng E5 RON 92 giảm 410 đồng / lít; xăng RON 95 giảm 110 đồng / lít." +
                "Các loại dầu cũng giảm giá." +
                "Cụ thể, giá dầu diesel giảm 400 đồng / lít, dầu hỏa 430 đồng / lít; dầu mazut giảm 1.010 đồng / kg." +
                "Sau nhiều ngày tăng sốc, giá xăng chiều nay giảm 110 - 410 đồng / lít - 1. " +
                "Sau điều chỉnh, giá xăng E5 RON 92 tối đa là 30.890 đồng / lít; RON 95 là 32.760 đồng / lít; dầu diesel là 29.610 đồng / lít, dầu hỏa là 28.350 đồng / lít, dầu mazut là 19.720 đồng / kg. " +
                "Tại kỳ điều hành này, Liên Bộ không chi quỹ bình ổn với xăng dầu, trích lập quỹ đối với xăng E5 RON 92 là 100 đồng / lít và dầu hỏa 300 đồng / lít, mazut 800 đồng / kg. " +
                "Như vậy, giá xăng dầu đã có lần đầu giảm giá sau chuỗi tăng 7 lần liên tiếp." +
                "Tuy nhiên, do mức giảm khá nhẹ nên giá cả mặt hàng hóa này vẫn ở mức rất cao. " +
                "Để hạ nhiệt giá xăng dầu, Bộ Tài chính đã đưa giải pháp giảm thuế bảo vệ môi trường. " +
                "Mới đây, Bộ Tài chính đã trình thêm phương án giảm thêm thuế tiêu thụ đặc biệt và VAT để kìm giá xăng.", "2022-07-01", "Xã hội", "asset/images/xang.jpg", "#"));
            newslist.Add(new News(5,
                "Sau nhiều ngày tăng 'sốc', giá xăng chiều nay giảm 110 - 410 đồng/lít",
                "Liên Bộ Tài chính, Bộ Công Thương vừa thay đổi giá bán lẻ xăng dầu trong kỳ điều chỉnh hôm nay (1/7). " +
                "Thời gian áp dụng bắt đầu từ 15h. " +
                "Theo đó, tại đợt điều chỉnh này, xăng E5 RON 92 giảm 410 đồng / lít; xăng RON 95 giảm 110 đồng / lít." +
                "Các loại dầu cũng giảm giá." +
                "Cụ thể, giá dầu diesel giảm 400 đồng / lít, dầu hỏa 430 đồng / lít; dầu mazut giảm 1.010 đồng / kg." +
                "Sau nhiều ngày tăng sốc, giá xăng chiều nay giảm 110 - 410 đồng / lít - 1. " +
                "Sau điều chỉnh, giá xăng E5 RON 92 tối đa là 30.890 đồng / lít; RON 95 là 32.760 đồng / lít; dầu diesel là 29.610 đồng / lít, dầu hỏa là 28.350 đồng / lít, dầu mazut là 19.720 đồng / kg. " +
                "Tại kỳ điều hành này, Liên Bộ không chi quỹ bình ổn với xăng dầu, trích lập quỹ đối với xăng E5 RON 92 là 100 đồng / lít và dầu hỏa 300 đồng / lít, mazut 800 đồng / kg. " +
                "Như vậy, giá xăng dầu đã có lần đầu giảm giá sau chuỗi tăng 7 lần liên tiếp." +
                "Tuy nhiên, do mức giảm khá nhẹ nên giá cả mặt hàng hóa này vẫn ở mức rất cao. " +
                "Để hạ nhiệt giá xăng dầu, Bộ Tài chính đã đưa giải pháp giảm thuế bảo vệ môi trường. " +
                "Mới đây, Bộ Tài chính đã trình thêm phương án giảm thêm thuế tiêu thụ đặc biệt và VAT để kìm giá xăng.", "2022-07-01", "Xã hội", "asset/images/xang.jpg", "#"));
            newslist.Add(new News(6,
                "Sau nhiều ngày tăng 'sốc', giá xăng chiều nay giảm 110 - 410 đồng/lít",
                "Liên Bộ Tài chính, Bộ Công Thương vừa thay đổi giá bán lẻ xăng dầu trong kỳ điều chỉnh hôm nay (1/7). " +
                "Thời gian áp dụng bắt đầu từ 15h. " +
                "Theo đó, tại đợt điều chỉnh này, xăng E5 RON 92 giảm 410 đồng / lít; xăng RON 95 giảm 110 đồng / lít." +
                "Các loại dầu cũng giảm giá." +
                "Cụ thể, giá dầu diesel giảm 400 đồng / lít, dầu hỏa 430 đồng / lít; dầu mazut giảm 1.010 đồng / kg." +
                "Sau nhiều ngày tăng sốc, giá xăng chiều nay giảm 110 - 410 đồng / lít - 1. " +
                "Sau điều chỉnh, giá xăng E5 RON 92 tối đa là 30.890 đồng / lít; RON 95 là 32.760 đồng / lít; dầu diesel là 29.610 đồng / lít, dầu hỏa là 28.350 đồng / lít, dầu mazut là 19.720 đồng / kg. " +
                "Tại kỳ điều hành này, Liên Bộ không chi quỹ bình ổn với xăng dầu, trích lập quỹ đối với xăng E5 RON 92 là 100 đồng / lít và dầu hỏa 300 đồng / lít, mazut 800 đồng / kg. " +
                "Như vậy, giá xăng dầu đã có lần đầu giảm giá sau chuỗi tăng 7 lần liên tiếp." +
                "Tuy nhiên, do mức giảm khá nhẹ nên giá cả mặt hàng hóa này vẫn ở mức rất cao. " +
                "Để hạ nhiệt giá xăng dầu, Bộ Tài chính đã đưa giải pháp giảm thuế bảo vệ môi trường. " +
                "Mới đây, Bộ Tài chính đã trình thêm phương án giảm thêm thuế tiêu thụ đặc biệt và VAT để kìm giá xăng.", "2022-07-01", "Xã hội", "asset/images/xang.jpg", "#"));

            Application["newslist"] = newslist;
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}