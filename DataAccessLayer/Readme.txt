- Migration amacı, code first yaklaşımı ile veritabanını inşaa etmektir. Entity'leri ve context sınıfında çağırdığımız dbset'leri 
ConnectionString üzerinden veritabanına yansıtmak şeklinde çalışır.

MIGRATION NASIL YAPILIR ?
1- Package manager console'da Default Project olarak DataAccessLayer(Context sınıfının bulunduğu katman olduğu için) seçilir. 
2- add-migration mig1 ile migration oluşturulur
3- update-database komutu ile de veritabanına yansıtılır

INTERFACE
- Her bir CRUD (Create, Read, Update, Delete) operasyonuna ait bir metot tanımlanacak.
- Metotların imzası olarak interface'ler kullanılacak. 
- Abstract üzerinde soyut ifade olarak interface'leri tanımlayıp, Conctrate üzerinde somut ifade olarak bu interfacelerdeki metodlar doldurulacak.
- Metotları generic yaparak bütününe uygulanmasını sağlayacağız.
- Ekleme, Silme, Güncelleme işlemleri için "void" metot türü kullanılacak.

GENERIC REPOSITORIES
- Kod tekrarının önüne geçmek ve yönetilebilirliği arttırmak için generic yapısı kullanılır.

EntityFramework klasöründeki tanımlamalarda, Hem generic repository özellikleri, hem de interface özelliklerini aldık
