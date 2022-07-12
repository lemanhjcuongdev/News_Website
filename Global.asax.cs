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
                "<br/>Đầu tiên, người lạ sẽ không thể xem hoặc bình luận trên nhật ký của người dùng.Ngoài ra, mỗi tài khoản Zalo giờ đây có 40 lần hiển thị / tháng khi người lạ tìm kiếm qua số điện thoại. " +
                "Bên cạnh đó, mỗi tài khoản chỉ được phản hồi 40 hội thoại / tháng từ người lạ.Thêm nữa, danh bạ sẽ chứa tối đa 1.000 liên hệ, tài khoản thường không được sử dụng username, mỗi tài khoản chỉ có 5 tin nhắn nhanh, nếu người dùng muốn thêm mới thì buộc phải xóa bớt tin nhắn nhanh cũ. " +
                "So với dịch vụ ban đầu, các tính năng phổ biến của Zalo sẽ bị giới hạn khá nhiều. " +
                "<br/>Trước đó, Zalo đã triển khai Gói dịch vụ trả phí với Zalo OA doanh nghiệp(bắt đầu từ ngày 22/6). " +
                "Các tính năng hỗ trợ doanh nghiệp là một phần của các gói sau: gói dùng thử(10.000 đồng), nâng cao(59.000 đồng), Premium(399.000 đồng). " +
                "Các tính năng hỗ trợ công việc kinh doanh bao gồm nhận diện thương hiệu, chatbot, tích hợp API, lượt tương tác nâng cao… " +
                "<br/>Hiện tại, Zalo đang là một trong những ứng dụng được nhiều người dùng tại Việt Nam sử dụng để liên lạc trực tuyến.Ước tính, có khoảng 70 triệu tài khoản đang hoạt động tại Việt Nam. " +
                "Trong năm 2021, 620 tỷ tin nhắn và có 52 tỷ phút gọi video được thực hiện qua Zalo.Những con số cho thấy người dùng phụ thuộc lớn vào ứng dụng này.",DateTime.Parse("2022-06-29"),"Khoa học & Công nghệ", "asset/images/Zalo1.jpg","#"));
            newslist.Add(new News(2,
                "Sau nhiều ngày tăng 'sốc', giá xăng chiều nay giảm 110 - 410 đồng/lít",
                "Liên Bộ Tài chính, Bộ Công Thương vừa thay đổi giá bán lẻ xăng dầu trong kỳ điều chỉnh hôm nay (1/7). " +
                "Thời gian áp dụng bắt đầu từ 15h. " +
                "<br/>Theo đó, tại đợt điều chỉnh này, xăng E5 RON 92 giảm 410 đồng / lít; xăng RON 95 giảm 110 đồng / lít." +
                "Các loại dầu cũng giảm giá." +
                "Cụ thể, giá dầu diesel giảm 400 đồng / lít, dầu hỏa 430 đồng / lít; dầu mazut giảm 1.010 đồng / kg." +
                "<br/>Sau điều chỉnh, giá xăng E5 RON 92 tối đa là 30.890 đồng / lít; RON 95 là 32.760 đồng / lít; dầu diesel là 29.610 đồng / lít, dầu hỏa là 28.350 đồng / lít, dầu mazut là 19.720 đồng / kg. " +
                "<br/>Tại kỳ điều hành này, Liên Bộ không chi quỹ bình ổn với xăng dầu, trích lập quỹ đối với xăng E5 RON 92 là 100 đồng / lít và dầu hỏa 300 đồng / lít, mazut 800 đồng / kg. " +
                "<br/>Như vậy, giá xăng dầu đã có lần đầu giảm giá sau chuỗi tăng 7 lần liên tiếp." +
                "Tuy nhiên, do mức giảm khá nhẹ nên giá cả mặt hàng hóa này vẫn ở mức rất cao. " +
                "<br/>Để hạ nhiệt giá xăng dầu, Bộ Tài chính đã đưa giải pháp giảm thuế bảo vệ môi trường. " +
                "Mới đây, Bộ Tài chính đã trình thêm phương án giảm thêm thuế tiêu thụ đặc biệt và VAT để kìm giá xăng.", DateTime.Parse("2022-06-18"), "Xã hội", "asset/images/xang.jpg","#"));
            newslist.Add(new News(3,
                "Cựu HLV trưởng ĐT Việt Nam đến TP.HCM, giải cứu đội bét bảng V-League?",
                "Chiều ngày 8/7, nhiều người bất ngờ thấy hình ảnh ông Toshiya Miura, cựu HLV trưởng ĐT Việt Nam xuất hiện ở một khách sạn tại quận 10, TP.HCM. Theo những hình ảnh đăng tải trên mạng xã hội, ông Miura bị bắt gặp khi đang tập thể dục trong khuôn viên của khách sạn. Đáng chú ý, chiến lược gia người Nhật Bản còn có cuộc gặp gỡ và trò chuyện với HLV Nguyễn Đức Thắng, cùng một số thành viên ban huấn luyện của CLB Bình Định.Bởi đội bóng đất võ cũng đang đóng quân tại đây để chuẩn bị cho cuộc đối đầu với CLB Sài Gòn ở vòng 6 V - League 2022(19h15 ngày 9 / 7). Việc HLV Toshiya Miura có mặt tại TP.HCM ở thời điểm này khiến nhiều người hâm mộ bóng đá Việt Nam nghĩ tới khả năng nhà cầm quân sinh năm 1963 có thể trở lại dẫn dắt một đội bóng tại V - League.Được biết, ông Miura đã chính thức bị đội bóng đang chơi ở J - League 3 là Gifu sa thải từ hồi đầu tháng 5, do thành tích khá tệ ở mùa giải này(thắng 2, hoà 1 và thua 4 trận dưới thời ông Miura). Trước khi dẫn dắt Gifu, HLV Miura từng thử sức ở đấu trường V - League khi dẫn dắt CLB TP.HCM năm 2017 và 2018, nhưng không để lại nhiều dấu ấn(CLB TP.HCM đứng thứ 12 ở V - League 2017 và 2018).Trở lại Việt Nam lần này, HLV Miura được cho là có mối liên hệ với CLB Sài Gòn, đội bóng đang đứng cuối cùng trên bảng xếp hạng V - League 2022 với vỏn vẹn 2 điểm sau 4 trận đã đấu. CLB Sài Gòn dưới thời chủ tịch Trần Hoà Bình luôn có mối quan hệ khá thân thiết với các đối tác từ Nhật Bản.Bởi vậy, khả năng một nhà cầm quân người Nhật Bản như ông Toshiya Miura trở lại “giải cứu” CLB Sài Gòn hoàn toàn có thể xảy ra. Một lãnh đạo cấp cao của CLB Sài Gòn cho biết họ vẫn đặt niềm tin vào HLV Phùng Thanh Phương vào thời điểm nhiều khó khăn này. Dù vậy, trong trường hợp đội chủ sân Thống Nhất không giành kết quả khả quan ở những vòng đấu sắp tới, trước mắt là cuộc đối đầu với Bình Định tối ngày 9 / 7, rất có thể sẽ có những thay đổi nơi cabin huấn luyện của CLB Sài Gòn.",
                DateTime.Parse("2022-07-12"), "Thể thao", "asset/images/tt1.jpg", "#"));
            newslist.Add(new News(4,
                "Tỉnh ở Việt Nam có thứ cả thế giới đang cần, dân thu nhập khủng cỡ nào?",
                "Vùng biển Bà Rịa - Vũng Tàu có khoảng 400 triệu m3 dầu, chiếm 93,29% trữ lượng cả nước và khoảng trên 100 tỷ m3 khí, chiếm 16,2% trữ lượng cả nước. Dầu mỏ và khí đốt ở vùng biển Bà Rịa - Vũng Tàu phân bổ chủ yếu tại bể Cửu Long và bể Nam Côn Sơn. Thực tế kinh tế của tỉnh Bà Rịa - Vũng Tàu cũng rất phát triển. Trong đó, báo cáo của Tổng cục Thống kê về chỉ số thu nhập GNI bình quân đầu người năm 2020 của Bà Rịa - Vũng Tàu đạt 34.580 USD, gấp 1,6 lần địa phương xếp thứ hai là Quảng Ninh.  Quy mô kinh tế của tỉnh năm 2020 tăng gấp 3 lần so với năm 2005; GRDP đứng thứ 4, tổng thu ngân sách đứng thứ 2 trong vùng. Mục tiêu đến năm 2030, Bà Rịa-Vũng Tàu phấn đấu trở thành địa phương phát triển trong nhóm dẫn đầu cả nước. Bà Rịa-Vũng Tàu cũng thường xuyên đứng trong nhóm 5 địa phương thu ngân sách cao nhất cả nước, có nhiều đóng góp vào ngân sách quốc gia và là một trong số ít tỉnh, thành phố tự cân đối ngân sách địa phương từ năm 1996 đến nay. Mục tiêu của tỉnh trong những năm tiếp theo là xây dựng Bà Rịa - Vũng Tàu thành nơi đáng sống, tạo ra giá trị lớn, mọi người dân đều có cuộc sống yên lành. Sau đại dịch Covid-19 nhu cầu về dầu tăng cao, thêm vào đó, căng thẳng giữa Nga - Ukraine khiến cho giá dầu luôn ở mức trên 100 USD/thùng. Matt Smith - nhà phân tích dầu khu vực châu Mỹ tại hãng phân tích Kpler cho rằng giá dầu sẽ neo ở mức 3 chữ số thêm một thời gian nữa ...",
                DateTime.Parse("2022-07-07"), "Xã hội", "asset/images/kd3.jpg", "#"));
            newslist.Add(new News(5,
                "Ông Abe bị bắn tử vong: Cú sốc ở quốc gia kiểm soát súng đạn gắt gao nhất thế giới",
                "Chánh văn phòng nội các Nhật Bản Hirokazu Matsuno xác nhận cựu thủ tướng Abe Shinzo bị bắn khi đang vận động tranh cử cho đảng Dân chủ Tự do ở thành phố Nara, miền tây nước này. Đại sứ Mỹ tại Nhật Bản Rahm Emanuel bày tỏ sự đau buồn và sốc trước thông tin ông Abe bị ám sát. 'Chúng tôi đau buồn và bị sốc khi cựu Thủ tướng Abe Shinzo bị bắn', Đại sứ Emanuel cho biết. 'Abe là nhà lãnh đạo kiệt xuất của Nhật Bản và là đồng minh không lay chuyển của Mỹ'. 'Đây là một cú sốc lớn', Hiromichi Watanabe, thành viên cấp cao đảng Dân chủ Tự do Nhật Bản phát biểu. 'Tôi không thể tin rằng điều này có thể xảy ra ở Nhật Bản'. Ông Abe bị chảy máu ở ngực và được đưa đi cấp cứu trong trạng thái 'ngừng tim phổi', sau đó đã qua đời trong bệnh viện. Nghi phạm Tetsuya Yamagami, 41 tuổi, bị bắt tại hiện trường cùng vũ khí gây án dường như là một khẩu súng săn tự chế. Theo CNN, Nhật Bản là một trong những quốc gia có tỉ lệ phạm tội liên quan đến súng đạn ở mức thấp nhất thế giới vì quy định kiểm soát nghiêm ngoặt. Năm 2018, Nhật Bản chỉ ghi nhận 9 trường hợp tử vong liên quan đến súng đạn, so với 39.740 trường hợp trong cùng năm ở Mỹ. Ở Nhật Bản, chỉ có súng shotgun(súng bắn đạn ghém) và súng săn là vũ khí được cấp phép sử dụng.Súng ngắn và súng quân dụng bị nghiêm cấm.Người dân Nhật Bản có thể xin giấy phép sử dụng súng săn nhưng quy trình rất phức tạp và cần sự kiên nhẫn. Chủ sở hữu súng phải cất giữ vũ khí ở nơi riêng biệt, có khóa và chìa khóa, sau đó thông báo với cảnh sát. Cứ ba năm một lần, họ phải tham gia lại khóa học và thực hiện đợt kiểm tra. 'Nhật Bản từ lâu đã thực thi luật kiểm soát súng rất chặt chẽ', Iain Overton, giám đốc điều hành Tổ chức Hành động về Bạo lực Vũ trang(AOAV) của Anh, nói trên BBC. 'Nhật Bản là quốc gia đầu tiên trên toàn thế giới áp dụng luật về súng, nhằm đảm bảo súng thực sự không đóng vai trò nào trong xã hội dân sự'. Theo CNN, để mua được một khẩu súng ở Nhật Bản, người Nhật phải tham gia khóa học cả ngày, bao gồm bài kiểm tra viết và bài kiểm tra sử dụng súng với độ chính xác ít nhất 95 % ...",
                DateTime.Parse("2022-07-08"), "Xã hội", "asset/images/tg2.jpg", "#"));
            newslist.Add(new News(6,
                "Top smartphone Android cận cao cấp mạnh nhất hiện nay",
                "Nhóm nghiên cứu điểm chuẩn AnTuTu đã công bố bảng xếp hạng smartphone Android tầm trung và cận cao cấp hàng đầu trong tháng 6/2022 cho thị trường quốc tế. Theo các chuyên gia AnTuTu, không có mẫu điện thoại nào sử dụng chip Samsung và Huawei, tương ứng Exynos và Kirin, lọt vào top bảng xếp hạng của tháng 6. Trong khi chip Kirin của Huawei biến mất khỏi bảng xếp hạng do các lệnh trừng phạt chưa được giải quyết thì Exynos lại bị ảnh hưởng bởi hiệu suất kém. Vị trí đầu tiên trong bảng xếp hạng các điện thoại cận cao cấp thuộc về Poco F3, thứ hai thuộc về Google Pixel 6 Pro và vị trí thứ ba thuộc về Google Pixel 6. Làm tròn danh sách 10 sản phẩm đứng đầu ở các vị trí tiếp theo lần lượt thuộc về Xiaomi Mi 11X, Black Shark 4, Realme GT Neo2T, Redmi K40, Mi 12X, Realme GT Neo, OnePlus 9R ...",
                DateTime.Parse("2022-06-18"), "Khoa học & Công nghệ", "asset/images/t1.jpg", "#"));
            newslist.Add(new News(7,
                "Đã có ngày ra mắt chiếc MacBook đang được chờ đợi nhất",
                "Một tháng đã trôi qua kể từ khi Apple giới thiệu MacBook Air M2 tại WWDC 2022, công ty cuối cùng cũng xác nhận thời điểm phát hành sản phẩm này. Trong khi MacBook Pro M2 đã đến tay khách hàng nhanh chóng, MacBook Air M2 vẫn bặt vô âm tín cho đến thời điểm này khi Apple xác nhận sản phẩm sẽ có sẵn để đặt hàng trực tuyến từ ngày 8 / 7 tới đây.Đây là thời điểm mà người dùng có thể đặt hàng sản phẩm thông qua trang web của Apple.Công ty đã thông báo rằng sự ra mắt này sẽ diễn ra trên toàn cầu và MacBook Air M2 sẽ lên kệ đầu tiên vào ngày 15 / 7." +
                "MacBook Air M2 là một trong những sản phẩm được chờ đợi nhất ngay sau khi WWDC 2022 diễn ra, đặc biệt khi sản phẩm mang đến một thiết kế hoàn toàn mới cũng như đi kèm chip M-series mới nhất của Apple Silicon. Trong khi đó, MacBook Pro M2 chỉ là một bản cập nhật nhỏ cho mẫu trước đó sau khi đã trải qua nhiều thay đổi trong thiết kế. MacBook Air M2 chỉ dày 11mm và nặng chưa đến 1, 3 kg, đi kèm tấm nền Retina Liquid Display 13, 6 inch và thiết kế có thể nâng cấp lên đến chip Apple M2 với GPU 10 lõi, RAM LPDDR5 lên đến 24 GB và ổ SSD dung lượng 2 TB. MacBook Air M2 có khả năng hoạt động trong tối đa 18 giờ với một lần sạc pin. Giống như các mẫu Pro cao cấp hơn, sản phẩm hỗ trợ sạc nhanh cho phép nạp 50 % năng lượng chỉ trong 30 phút bằng bộ sạc USB - C 67W.Bên cạnh MacBook Air, Apple cũng tiết lộ bộ sạc 35W mới với 2 cổng USB - C để có thể sạc hai thiết bị cùng một lúc." +
                "Về giá bán, MacBook Air M2 được bán với giá khởi điểm 1.199 USD (27,8 triệu đồng) cho cấu hình cơ bản gồm 8 lõi CPU và GPU, RAM 8 GB và SSD 256 GB. Phiên bản cao cấp nhất có 10 lõi GPU và SSD 512 GB đi kèm bộ sạc 35W mới với 2 cổng USB-C được bán với giá 1.499 USD (34,76 triệu đồng). Bản cơ bản chỉ đi kèm bộ sạc USB-C 30W. Điều thú vị là Apple vẫn quyết định bán MacBook Air M1, nơi người dùng có thể mua với giá 999 USD (23,16 triệu đồng).",
                DateTime.Parse("2022-07-09"), "Khoa học & Công nghệ", "asset/images/t7.jpg", "#"));
            newslist.Add(new News(8,
                "Đây là những smartphone cao cấp sẽ tạo sóng cuối 2022",
                "Trong 6 tháng đầu năm qua, công chúng đã chứng kiến sự xuất hiện của nhiều flagship mới: Galaxy S22 Series, Xiaomi 12 Series, OnePlus 10 Pro, Vivo X80 Pro,… Và 6 tháng còn lại vẫn có nhiều “siêu phẩm” khác để các fan công nghệ đón chờ." +
                "<br/>Trong bộ tứ iPhone 14, dự kiến ra mắt vào tháng 9, cặp iPhone 14 Pro/ iPhone 14 Pro Max là tâm điểm của sự chú ý. Chúng được dự đoán là 2 trong số những smartphone tốt nhất của năm nay với nhiều thay đổi, nâng cấp từ trong ra ngoài." +
                "Cụ thể, các tin đồn đều chỉ ra rằng 2 phiên bản iPhone Pro tiếp theo sẽ được tích hợp chip A16 Bionic (được sản xuất trên quy trình 5nm tiên tiến hơn), màn hình có vết cắt “đục lỗ” + “viên thuốc” kiểu mới, tính năng màn hình luôn bật tiện lợi. Thêm vào đó, camera chính của máy cũng sẽ sử dụng cảm biến 48MP – gấp 4 lần độ phân giải so với camera 12MP hiện tại. Chưa hết, chúng cũng có camera selfie được nâng cấp với tính năng lấy nét tự động. Với mức giá dự kiến từ 1099 USD(tương đương 25, 66 triệu đồng) và 1199 USD(khoảng 28 triệu đồng), bộ đôi iPhone 14 Pro / iPhone 14 Pro Max đích thực là sản phẩm “đắt xắt ra miếng” của Apple. " +
                "<br/>Dự kiến trình làng vào tháng 8 tới, Galaxy Z Fold 4/ Galaxy Z Flip 4 sẽ là bản kế nhiệm của cặp Galaxy Z Fold 3/ Galaxy Z Flip 3 – hiện đang được giảm giá mạnh. Hai chiếc smartphone màn hình gập cao cấp của Samsung được cho là khắc phục các nhược điểm của thế hệ trước, tích hợp chip Snapdragon 8+ Gen 1 mạnh mẽ. 2 sản phẩm sẽ có nếp gấp màn hình nhỏ hơn, bản lề nhỏ hơn và nhẹ hơn, tỷ lệ khung hình rộng hơn và viền mỏng hơn. Đặc biệt, Galaxy Z Fold 4 sẽ có RAM lên tới 16GB, bộ nhớ trong đạt 1TB, camera chính có thể nâng cấp lên 50MP xịn sò hơn." +
                "<br/>Nếu theo đúng lịch trình, 2 chiếc điện thoại cao cấp của Google sẽ được ra mắt vào tháng 10 này. Hình ảnh kết xuất được cho là Pixel 7 Pro cho thấy màn hình sẽ được làm cong xung quanh các cạnh, giống như trên Pixel 6 Pro. Pixel 7 giống như Pixel 6, sẽ có màn hình phẳng và kích thước tổng thể nhỏ hơn. Thêm vào đó, độ mở của camera tele trên chiếc Pixel 7 Pro có thể lớn hơn so với Pixel 6 hiện tại, dự kiến chứa một ống kính hoặc khẩu độ rộng. Từ đó, cho phép chụp ảnh sáng và rõ nét hơn. Thêm vào đó, cặp Pixel mới sẽ được tích hợp chip Tensor thế hệ thứ 2, được tinh chỉnh từ thế hệ thứ nhất, cho trải nghiệm “chất” hơn." +
                "<br/>Năm nay, OnePlus 10 Pro cao cấp đã được công bố sớm từ đầu năm. Nhưng hãng vẫn còn 1 “kho báu” dự kiến giới thiệu vào nửa cuối năm nay – OnePlus 10 Ultra. Sản phẩm sẽ có cấu hình “khủng” hơn với chip xịn hơn – Snapdragon 8+ Gen 1 của Qualcomm. Theo các tin đồn, chiếc điện thoại này của OnePlus sẽ cung cấp khả năng sạc nhanh lên tới 150W, có thể “đánh bại” mọi flagship trên thị trường hiện tại. Với việc chỉnh trang lại thiết kế từ OnePlus 10 Pro “anh em”, OnePlus 10 Ultra hứa hẹn sẽ có sức cạnh tranh mạnh với Galaxy S22 Ultra và nhiều điện thoại cao cấp khác.",
                DateTime.Parse("2022-07-10"), "Khoa học & Công nghệ", "asset/images/t9.jpg", "#"));
            newslist.Add(new News(9,
                "Ronaldo bỏ tập đòi rời MU: Có xứng đáng làm huyền thoại Quỷ đỏ?",
                "Trong khoảng 2 thập kỷ, fan MU đã tự hào về sức hút của CLB mình vì những thành công vang dội dưới triều đại của Sir Alex Ferguson. Sau khi Fergie nghỉ hưu, “Quỷ Đỏ” vẫn dùng danh tiếng của mình để chiêu mộ ngôi sao mặc dù thành tích trên sân bắt đầu thụt lùi: Paul Pogba, Zlatan Ibrahimovic đến với MU năm 2016 khi CLB này sẽ phải đá Europa League. " +
                "<br/>Nhưng 6 năm sau, một cuộc tháo chạy đã và đang diễn ra trước thềm một mùa giải nữa MU phải dự sân chơi hạng 2 ở cấp độ châu lục. 7 cầu thủ chia tay CLB trong mùa hè năm nay do hợp đồng đáo hạn, bao gồm Pogba, Nemanja Matic và Juan Mata... " +
                "<br/>Nhưng có lẽ cuộc tháo chạy lớn nhất sắp đến: Cristiano Ronaldo đang bỏ tập tại MU để đòi ra đi." +
                "<br/>Tính chất bất ngờ của vấn đề nằm ở chỗ Ronaldo được xem là một hình mẫu của sự chuyên nghiệp và kỷ luật. Chúng ta đã nghe cả tá câu chuyện về cách Ronaldo tập, giờ giấc sinh hoạt, chế độ ăn uống, v.v… Anh được cho là không bao giờ đi chệch theo chế độ mà mình đã vạch ra, khiến các đồng nghiệp luôn bày tỏ sự khâm phục. " +
                "<br/>Thế nên việc Ronaldo bỏ tập nhiều ngày liền chắc chắn khiến nhiều fan MU thất vọng, nhưng đó là một cảm giác quen thuộc với các cổ động viên Juventus. 1 năm trước CR7 cũng bỏ tập trước khi chuẩn bị rời Turin, điều khác biệt duy nhất là danh thủ người Bồ Đào Nha vẫn lên đồ và ra sân thi đấu một trận ở đầu mùa giải cho “Bà đầm già” trước khi vụ chuyển nhượng diễn ra." +
                "<br/>Thất vọng hơn nữa là Ronaldo bắt đầu “dở chứng” vào thời điểm sự chuẩn bị cho mùa giải mới đã bắt đầu cho MU dưới sự dẫn dắt của tân HLV Erik Ten Hag. Nếu như năm ngoái sự việc diễn ra muộn hơn do Ronaldo bận thi đấu ở EURO, năm nay World Cup không đá mùa hè và Ronaldo có cả tháng để nói cho ban lãnh đạo MU biết rằng mình không có dự định thi đấu ở Europa League ...",
                DateTime.Parse("2022-07-09"), "Thể thao", "asset/images/tt7.jpg", "#"));
            newslist.Add(new News(10,
                "'Nhạc trưởng' Pau FC 35 tỷ đồng ra đi, cơ hội đá chính của Quang Hải thế nào?",
                "Cơ hội của Quang Hải tại Pau FC ra sao với sự ra đi của Victor Lobry?" +
                "<br/>Mùa hè 2022, Pau FC tạo ra những cú sốc chuyển nhượng liên tiếp. Bao gồm cả bản hợp đồng miễn phí mang tên Nguyễn Quang Hải, đội chủ sân Nouste Camp đón tới 11 tân binh. Điều đó có nghĩa, Pau FC đã thay cả đội hình." +
                "Có 11 người đến ắt phải có kẻ đi. Theo trang Transfermarkt, đội bóng hạng 2 Pháp cũng chia tay không ít trụ cột. Theo chiều ngược lại, 6 cầu thủ đã rời sân Nouste Camp sau nhiều năm gắn bó." +
                "<br/>Điều đáng nói, những cầu thủ đã rời Pau FC hè này hầu hết có giá trị cao hơn so với những người mới đến.Thủ môn Stefan Bajic là nhân tố được đánh giá cao nhất trong đội hình Pau FC mùa trước, với giá trị chuyển nhượng theo trang Transfermarkt lên tới 1, 8 triệu euro.Trong khi đó, tiền vệ Victor Lobry giá 1, 5 triệu euro, các cầu thủ khác như Samuel Essende hay Quentin Daubin đều có giá 800.000 euro." +
                "<br/>Cá nhân Quang Hải sẽ có cơ hội nhất định cho riêng mình sau khi Victor Lobry rời đi.Tiền vệ 27 tuổi người Pháp cũng thuận chân trái như Quang Hải, đã gắn bó với Pau FC từ năm 2020 và đang bước vào độ chín nhất sự nghiệp." +
                "<br/>Do vậy, nếu Lobry còn hiện diện ở Nouste Camp, cuộc chiến vị trí sẽ trở nên vô cùng khốc liệt với tuyển thủ Việt Nam.Một vài con số thống kê chỉ ra điều đó.Ligue 2 mùa giải 2020 / 21, Lobry chơi 3.226 phút, cao thứ hai toàn đội.Anh có cho riêng mình 5 bàn thắng và 3 đường kiến tạo." +
                "<br/>Một chi tiết thú vị khác liên quan đến Victor Lobry.Sau khi cầu thủ này rời Pau FC, anh đã để lại chính chiếc áo số 19 cho Quang Hải.Nhờ vậy, nhà vô địch AFF Cup 2018 được mặc số áo quen thuộc mà anh đã gắn bó cả với CLB Hà Nội lẫn các cấp độ của ĐT Việt Nam." +
                "<br/>Lúc này, Erwin Koffi đang là cầu thủ được Transfermarkt thẩm định giá trị chuyển nhượng cao nhất.Tuy nhiên, hậu vệ này cũng chỉ được định giá 900.000 euro.Trong khi đó, Quang Hải ở trong nhóm hạng trung bình khá, với mức thẩm định 400.000 euro.",
                DateTime.Parse("2022-07-13"), "Thể thao", "asset/images/tt2.jpg", "#"));

            Application["newslist"] = newslist;

            List<User> users = new List<User>();
            users.Add(new User(1, "admin", "admin123", "admin"));
            Application["Users"] = users;


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