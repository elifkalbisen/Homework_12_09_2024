1. Veritabanı ve RDBMS Nedir?

Veritabanı Nedir?

Veritabanı, organize edilmiş bir bilgi kümesidir. Verilerin sistematik bir şekilde depolandığı ve yönetildiği bir yapıdır. Veritabanları, verilerin hızlı bir şekilde erişilmesine ve işlenmesine olanak tanır.

İlişkisel Veritabanı Yönetim Sistemlerinin (RDBMS) Temel Özellikleri:

-Veri Yapısı: Veriler, tablolar halinde düzenlenir; her tablo, satır ve sütunlardan oluşur.
-İlişkiler: Tablolar arasında ilişkiler kurma yeteneği.
-SQL Desteği: Veri sorgulama ve yönetimi için SQL (Structured Query Language) kullanılır.
-Veri Bütünlüğü: Veri tutarlılığını sağlamak için çeşitli kurallar ve kısıtlamalar uygulanır.
-Transaction Yönetimi: Veritabanı işlemlerinin güvenli bir şekilde yapılmasını sağlar (ACID özellikleri).

2. SQL ve Veri Yönetimi

SQL Nedir ve Neden Önemlidir?

SQL (Structured Query Language), veritabanları ile iletişim kurmak için kullanılan standart bir dildir. Verilerin sorgulanması, güncellenmesi, silinmesi ve yönetilmesi için gereklidir.

SQL’in Temel Komutları:

-SELECT: Verileri sorgulamak için kullanılır.
-INSERT: Yeni veriler eklemek için kullanılır.
-UPDATE: Var olan verileri güncellemek için kullanılır.
-DELETE: Verileri silmek için kullanılır.
-CREATE: Yeni veritabanı ve tablolar oluşturmak için kullanılır.
-DROP: Veritabanı veya tablo silmek için kullanılır.

3. Dapper Nedir?

Dapper Nedir ve Neden Kullanılır?

Dapper, .NET uygulamaları için bir mikro ORM (Object-Relational Mapper) kütüphanesidir. Veritabanı erişimini kolaylaştırmak ve hızlandırmak için kullanılır.

Dapper’ın Avantajları:

-Hız: Dapper, yüksek performans sunar ve diğer ORM'lere göre daha hızlıdır.
-Basitlik: Kullanımı kolay ve anlaşılır bir API sunar.
-Esneklik: SQL sorgularını doğrudan yazma imkanı verir.

Dapper’ın Dezavantajları:

-Tam Özellik Eksikliği: Diğer ORM'lerin sunduğu bazı gelişmiş özelliklere sahip değildir.
-Yapısal Kontrol: Veri modelinin doğru bir şekilde haritalanmasını gerektirir, bu da bazen karmaşık olabilir.

4. Veri Normalizasyonu

Veri Normalizasyonu Nedir?

Veri normalizasyonu, veritabanı tasarımında tekrar eden verilerin azaltılması ve veri tutarlılığının sağlanması sürecidir. Bu süreç, verilerin daha verimli bir şekilde depolanmasını ve yönetilmesini sağlar.

Normalizasyonun Faydaları:

-Veri Tutarlılığı: Verilerin tutarlı ve güncel kalmasını sağlar.
-Depolama Verimliliği: Gereksiz verilerin silinmesiyle depolama alanı tasarrufu sağlar.
-Daha İyi Performans: Sorguların daha hızlı çalışmasını sağlar.

5. SQL Injection Nedir?

SQL Injection Saldırısı Nedir?

SQL injection, kötü niyetli bir kullanıcının SQL sorgularını manipüle ederek veritabanına yetkisiz erişim sağlamaya çalıştığı bir saldırı türüdür.

Nasıl Korunulur?

-Hazırlanmış İfadeler (Prepared Statements): Kullanıcı girdilerini doğrudan sorgulara eklemek yerine, hazırlanan ifadeler kullanmak.
-Girdi Doğrulama: Kullanıcıdan alınan verilerin uygun şekilde kontrol edilmesi.
-Güvenlik Duvarları ve İzleme: Veritabanı sunucusunu korumak için güvenlik önlemleri almak.
