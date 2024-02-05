# Ufak Projeler

İzlemekte olduğum C# ile ilgili videoların sonunda aşama aşama yapmış olduğum projemi tek bir repoda topluyorum.
Proje notları bölümünde de yaptıklarımla ilgili aşama aşama bilgi vereceğim.
Repoyu günaşırı güncelleyip ilerleyen zamanlarda çeşitlendirmeyi ve daha elle tutulur projeler üretmeyi amaçlıyorum.

##Projelerin Notları

1-Araç Kullanımları isimli projede yapmış olduğum textboxlara girilen verileri labelda gösterme ve buttona basıldığında messagebox özelliği ile kullanıcıya bilgi verme    
2-ComboBoxveListBox isimli projede Form1.cs dosyasında textbox'a girilen verinin combobox listesinde gösterilmesi ve textboxa girilen veri sonrası buttona basıldığında listboxa girilen verinin eklenmesi.  
  Dipnot olarak eklemek isterim -> Listboxun altındaki Ekle butonuna tıklanıldığında önceden girmiş olduğumuz verinin listboxa otomatik eklenmesi de var.  
2.1-Form2.cs dosyasında yapılan pekiştirme amaçlı olup texboxtaki verilerin listboxa eklenmesidir. Dipnot: listboxun üstündeki yazılar görsel amaçlı boş olmaması amaçlı olup girilen verilerin hizalanmadığını belirtmek isterim.  
3-Maskedtextbox-Picturebox-Datetimepicker Form1.cs dosyasında textboxların listboxlara eklenmesi harici picturebox ve datetimepicker kullanıp listboxa eklenmesi var. Pek de mühim bir şey değil yani :)  
3.1-Form2.cs dosyasında yapılan pekiştirme amaçlı olup textbox ve datetimepickerda girilen verilerin listboxa eklenmesidir.  
4-Basit bir tasarım olup sadece panele checkboxun eklenmesidir. geriye dönük olarak belki veritabanı bağlantısı yaptıktan sonra "şifremi unuttum" yazısında bir güncelleme yapıp şifre değiştirme işlemini gerçekleştirebiliri. belki de yapmam bu kadar basit bir şey için...  
5-Ucus_Rezervasyon_Sistemi isimli projede (aslında bunu githuba yükleyim ya) düşüncesini oluşturan tatlı tasarım. Yukarıdaki baktığınız veya okuduğunuz diğer projeden ayıran tek şey "Nereden-Nereye" kısmı. Açıklamasını mümkün olduğunca sade yapmak istiyorum.
Amacım Nereden-Nereye bölümünde comboboxta hazır olan veriler seçildikten sonra bu iki comboboxtaki verilerin yerlerini değiştirecek bir button olması. Anlatımı uzatıp kafa karıştırmak istemiyorum ama olay şu 
  
label9.Text = comboBox2.Text;  
comboBox2.Text = comboBox1.Text;  
comboBox1.Text = label9.Text;  
bunu anlatmak istersem yazı uzayacak, yaptığım şeyin mantığını da anlatmak istiyorum ama temel düzey bir iş olduğu için "Bakın Amerikayı keşfettim!!!" gibi bir üslupta anlatırım diye tırsıyorum. Neyse efenim işte olay bu, 3 satırlık basit bir kodla iki comboboxın içindeki verilerin yerlerini değiştirdim 
