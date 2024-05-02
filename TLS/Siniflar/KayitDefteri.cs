using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TLS.Siniflar
{
    
    static class KayitDefteri
    {
        /*
         İlgili sınıf yalnızca mevcut kullanıcı ve osu kullanan diğer kullanıcıları ilgilendiren işlemleri kapsayacağı için ortam kısmında 
         yalnızca mevcut kullanıcı ve cihaz baz alınmıştur.
        Silme ve ekleme işlemine ihtiyaç olmadığı için anahtar silme ile ekleme blokları eklenmemiştir. Yalnızca güncelleme işlemi amaçlanmıştır.
         */
        public enum makineOrtam
        {
            mevcutMakine,
            mevcutKullanici
        }

        public enum deger
        {
            REG_SZ,
            REG_BINARY,
            REG_DWORD,
            REG_MULTI_SZ,
            REG_EXPAND_SZ
        }

        public static RegistryKey AnahtarGetir_alt(string konum, makineOrtam makine, bool degisiklikYapilabilir=false)
        {
            RegistryKey kayıtAnahari; 
            if (makine == makineOrtam.mevcutMakine)
            {
                kayıtAnahari = Registry.LocalMachine.OpenSubKey(name: konum, writable: degisiklikYapilabilir);
            }
            else
            {
                kayıtAnahari = Registry.CurrentUser.OpenSubKey(name: konum, writable: degisiklikYapilabilir);
            }
            return kayıtAnahari;
        }

        public static object anahtarDegeriniAl(RegistryKey anahtar)
        {
            if (anahtar == null)
            {
                throw new Exception("Anahtar değeri bulunamadı!");
            }
            
            return null;
        }

        public static bool kayitVarmi(string konum, string veri)
        {
            List<object> anahtarListesi = new List<object>();
            using (RegistryKey anahtar = Registry.LocalMachine.OpenSubKey(konum))
            {
                if (anahtar != null)
                {
                    if (anahtar.GetValue(veri) != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        public static void anahtarGuncelle(string konum, string anahtar, object yenideger, deger deger, makineOrtam ortam)
        {
            RegistryKey registryKey = KayitDefteri.AnahtarGetir_alt(konum, ortam, true);
            registryKey.SetValue(anahtar, yenideger);
            registryKey.Flush();
        }

        public static List<object> anahtarlariGetir(string konum, makineOrtam ortam, string baslayan = null)
        {
            List<object> anahtarListesi = new List<object>();
            using (RegistryKey anahtar = Registry.LocalMachine.OpenSubKey(konum))
            {
                if (anahtar != null)
                {
                    string[] altAnahtarlar = anahtar.GetSubKeyNames();
                    foreach (var anahtarlar in altAnahtarlar)
                    {
                        if (baslayan != null)
                        {
                            if ((anahtarlar.ToLower()).StartsWith(baslayan.ToLower()))
                                anahtarListesi.Add(anahtarlar);
                        }
                        else
                        {
                            anahtarListesi.Add(anahtarlar);
                        }
                    }
                }
            }

            return anahtarListesi;
        }
    }
}
