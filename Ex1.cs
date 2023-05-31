using System.Collections.Generic;

namespace Ex1
{
    public class SinhVien
    {
        public int maSV;
        public static int dem = 0;
        public string ten;
        public string gioitinh;
        public int tuoi;
        public float diemToan;
        public float diemLy;
        public float diemHoa;
        public float diemTB;

        public SinhVien()
        {
            maSV = 0;
            ten = "0";
            gioitinh = "0";
            tuoi = 9;
            diemToan = 0;
            diemLy = 0;
            diemHoa = 0;
            diemTB = 0;
        }

        public SinhVien(string ten, string gioitinh, int tuoi, float diemToan, float diemLy, float diemHoa)
        {
            maSV = dem;
            dem += 1;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.tuoi = tuoi;
            this.diemToan = diemToan;
            this.diemLy = diemLy;
            this.diemHoa = diemHoa;
            diemTB = TinhDiemTB(diemToan, diemLy, diemHoa);
        }

        public float TinhDiemTB(float diemToan, float diemLy, float diemHoa)
        {
            return (diemToan + diemLy + diemHoa) / 3;
        }
    }

    public class QLSV
    {
        public static void Main()
        {
            List<SinhVien> tongSinhVien = new List<SinhVien>();


            int n;
            Console.Write("Nhap n sinh vien: ");
            n = Convert.ToInt16(Console.ReadLine());

            NhapSinhVienBanDau(tongSinhVien, n);
            XuatSinhVien(tongSinhVien);

            SuDungMenu();

            while(!KetThucChuongTrinh)
            {
                Console.WriteLine("\n1: Them Sinh Vien");
                Console.WriteLine("2: Cap nhat thong tin Sinh Vien boi MaSV");
                Console.WriteLine("3: Xoa Sinh Vien boi MaSV");
                Console.WriteLine("4: Tim kiem Sinh Vien theo ten");
                Console.WriteLine("5: Sap xep Sinh Vien theo diem TB");

                int nMenu;
                Console.Write("\nNhap so cua chuc nang ban muon su dung: ");
                nMenu = Convert.ToInt16(Console.ReadLine());

                switch (nMenu)
                {
                    case 1:
                        NhapSV(tongSinhVien, tongSinhVien.Count);
                        SuDungMenu();
                        continue;
                    case 2:
                        CapNhatThongTin(tongSinhVien);
                        SuDungMenu();
                        continue;
                    case 3:
                        XoaThongTin(tongSinhVien);
                        SuDungMenu();
                        continue;
                    case 4:
                        TimKiemThongTinSinhVienTheoTen(tongSinhVien);
                        SuDungMenu();
                        continue;
                    case 5:
                        SapXepSinhVienTheoDiemTB(tongSinhVien);
                        SuDungMenu();
                        continue;
                    default:
                        Console.Write("\nVui long nhap dung so!");
                        SuDungMenu();
                        continue;
                }
            }            
        }

        static void SuDungMenu()
        {
            string yNQ;
            Console.Write("\nBan co muon ket thuc chuong trinh? (y/n) ");
            yNQ = Convert.ToString(Console.ReadLine());

            if (yNQ == "y")
            {
                KetThucChuongTrinh = true;
            }
            else if (yNQ == "n")
            {
                KetThucChuongTrinh = false;
            }
        }
        static bool ketThucChuongTrinh;
        static bool KetThucChuongTrinh
        {
            get
            {
                return ketThucChuongTrinh;
            }
            set
            {
                ketThucChuongTrinh = value;
            }
        }

        static void NhapSinhVienBanDau(List<SinhVien> tongSinhVien, int n)
        {
            for (int i = 0; i < n; i++)
            {
                NhapSV(tongSinhVien, i);
            }
        }

        static void NhapSV(List<SinhVien> tongSinhVien, int i)
        {
            SinhVien sinhVien = new SinhVien();
            Console.Write("\nNhap Ten Sinh Vien " + (i + 1) + ": ");
            sinhVien.ten = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap Gioi Tinh Sinh Vien " + (i + 1) + ": ");
            sinhVien.gioitinh = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap Tuoi Sinh Vien " + (i + 1) + ": ");
            sinhVien.tuoi = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap Diem Toan Sinh Vien " + (i + 1) + ": ");
            sinhVien.diemToan = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap Diem Ly Sinh Vien " + (i + 1) + ": ");
            sinhVien.diemLy = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap Diem Hoa Sinh Vien " + (i + 1) + ": ");
            sinhVien.diemHoa = (float)Convert.ToDouble(Console.ReadLine());
            sinhVien = new SinhVien(sinhVien.ten, sinhVien.gioitinh, sinhVien.tuoi, sinhVien.diemToan, sinhVien.diemLy, sinhVien.diemHoa);
            tongSinhVien.Add(sinhVien);
        }

        static void XuatSinhVien(List<SinhVien> tongSinhVien)
        {
            for (int i = 0; i < tongSinhVien.Count; i++)
            {
                XuatSV(tongSinhVien[i]);
            }
        }

        static void XuatSV(SinhVien sinhVien)
        {
            Console.WriteLine("\nMaSV: " + sinhVien.maSV);
            Console.WriteLine("Ten: " + sinhVien.ten);
            Console.WriteLine("Gioi Tinh: " + sinhVien.gioitinh);
            Console.WriteLine("Tuoi: " + sinhVien.tuoi);
            Console.WriteLine("Diem Toan: " + sinhVien.diemToan);
            Console.WriteLine("Diem Ly: " + sinhVien.diemLy);
            Console.WriteLine("Diem Hoa: " + sinhVien.diemHoa);
            Console.WriteLine("Diem TB: " + sinhVien.diemTB);
        }

        static void CapNhatThongTin(List<SinhVien> tongSinhVien)
        {
            int n;
            Console.Write("\nNhap maSV muon cap nhat thong tin: ");
            n = Convert.ToInt16(Console.ReadLine());

            for(int i = 0; i < tongSinhVien.Count; i++)
            {
                if (n == tongSinhVien[i].maSV)
                {
                    SinhVien sinhVien = new SinhVien();
                    Console.Write("\nNhap Ten Sinh Vien co maSV " + (n) + " sau khi cap nhat: ");
                    sinhVien.ten = Convert.ToString(Console.ReadLine());
                    Console.Write("Nhap Gioi Tinh Sinh Vien co maSV " + (n) + " sau khi cap nhat: ");
                    sinhVien.gioitinh = Convert.ToString(Console.ReadLine());
                    Console.Write("Nhap Tuoi Sinh Vien co maSV " + (n) + " sau khi cap nhat: ");
                    sinhVien.tuoi = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Nhap Diem Toan Sinh Vien co maSV " + (n) + " sau khi cap nhat: ");
                    sinhVien.diemToan = (float)Convert.ToDouble(Console.ReadLine());
                    Console.Write("Nhap Diem Ly Sinh Vien co maSV " + (n) + " sau khi cap nhat: ");
                    sinhVien.diemLy = (float)Convert.ToDouble(Console.ReadLine());
                    Console.Write("Nhap Diem Hoa Sinh Vien co maSV " + (n) + " sau khi cap nhat: ");
                    sinhVien.diemHoa = (float)Convert.ToDouble(Console.ReadLine());
                    sinhVien = new SinhVien(sinhVien.ten, sinhVien.gioitinh, sinhVien.tuoi, sinhVien.diemToan, sinhVien.diemLy, sinhVien.diemHoa);
                    sinhVien.maSV = n;
                    SinhVien tmp;
                    tmp = tongSinhVien[i];
                    tongSinhVien[i] = sinhVien;
                    sinhVien = tmp;
                    break;
                }
            }

            for (int i = 0; i < tongSinhVien.Count; i++)
            {
                XuatSV(tongSinhVien[i]);
            }
        }

        static void XoaThongTin(List<SinhVien> tongSinhVien)
        {
            int n;
            Console.Write("\nNhap maSV muon xoa thong tin: ");
            n = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < tongSinhVien.Count; i++)
            {
                if (n == tongSinhVien[i].maSV)
                {
                    tongSinhVien.RemoveAt(i);
                    break;
                }
            }

            Console.Write("\nList Sinh Vien sau khi xoa thong tin: ");
            for (int i = 0; i < tongSinhVien.Count; i++)
            {
                XuatSV(tongSinhVien[i]);
            }
        }

        static void TimKiemThongTinSinhVienTheoTen(List<SinhVien> tongSinhVien)
        {
            string name;
            Console.Write("\nNhap ten SV muon tim: ");
            name = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < tongSinhVien.Count; i++)
            {
                if (name.Equals(tongSinhVien[i].ten))
                {
                    XuatSV(tongSinhVien[i]);
                    break;
                }
                else
                {
                    Console.WriteLine("\nKhong tim thay Sinh Vien co ten " + name);
                    break;
                }
            }
        }

        static void SapXepSinhVienTheoDiemTB(List<SinhVien> tongSinhVien)
        {
            int n;
            Console.Write("\nNhap cach sap xep (1. Tang Dan, 2. Giam Dan): ");
            n = Convert.ToInt16(Console.ReadLine());

            if (n == 1)
            {
                SapXepTangDan(tongSinhVien);
                Console.Write("\nList Sinh Vien sau khi sap xep diem TB tang dan:");
            }

            else if (n == 2)
            {
                SapXepGiamDan(tongSinhVien);
                Console.Write("\nList Sinh Vien sau khi sap xep diem TB giam dan:");
            }

            for (int i = 0; i < tongSinhVien.Count; i++)
            {
                XuatSV(tongSinhVien[i]);
            }
        }

        static void SapXepTangDan(List<SinhVien> tongSinhVien)
        {
            SinhVien tmp;
            for (int i = 0; i < tongSinhVien.Count; i++)
            {
                for (int j = i + 1; j < tongSinhVien.Count; j++)
                {
                    if (tongSinhVien[j].diemTB < tongSinhVien[i].diemTB)
                    {
                        tmp = tongSinhVien[i];
                        tongSinhVien[i] = tongSinhVien[j];
                        tongSinhVien[j] = tmp;
                    }
                }
            }
        }

        static void SapXepGiamDan(List<SinhVien> tongSinhVien)
        {
            SinhVien tmp;
            for (int i = 0; i < tongSinhVien.Count; i++)
            {
                for (int j = i + 1; j < tongSinhVien.Count; j++)
                {
                    if (tongSinhVien[i].diemTB < tongSinhVien[j].diemTB)
                    {
                        tmp = tongSinhVien[j];
                        tongSinhVien[j] = tongSinhVien[i];
                        tongSinhVien[i] = tmp;
                    }
                }
            }
        }
    }
}