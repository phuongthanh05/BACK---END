using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap15
{
        class PhanSo : Program
        {
            public int TuSo { get; set; }
            public int MauSo { get; set; }

            public PhanSo(int tuSo, int mauSo)
            {
                TuSo = tuSo;
                MauSo = mauSo != 0 ? mauSo : 1;
            }

            public void RutGon()
            {
                int ucln = UCLN(TuSo, MauSo);
                TuSo /= ucln;
                MauSo /= ucln;
            }

            public static PhanSo Cong(PhanSo a, PhanSo b)
            {
                int tuMoi = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
                int mauMoi = a.MauSo * b.MauSo;
                PhanSo kq = new PhanSo(tuMoi, mauMoi);
                kq.RutGon();
                return kq;
            }

            private static int UCLN(int a, int b)
            {
                a = Math.Abs(a);
                b = Math.Abs(b);
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }

            public override string ToString()
            {
                return $"{TuSo}/{MauSo}";
            }
        }

    }



