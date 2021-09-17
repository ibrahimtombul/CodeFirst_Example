# CodeFirst_Example
C# Kodları ile Veritabanı Tablo oluşturma
Creating Database Table with C# Codes


Gerekli Paketler - Required Packages:

	Microsoft.EntityFrameworkCore
	Microsoft.EntityFrameworkCore.SqlServer

Opsiyonel Paket - Optional Package:

	cmd: dotnet tool install --global dotnet-ef


Aktarım Ayarları - Migration Settings:

Öncelikle konsol ekranında projenin dizini seçilmeli - First of all, the directory of the project should be selected on the console screen.

	cmd: cd D:\C#\CodeFirst_Example\CodeFirst_Example
	
Aktarım Dosyası oluşturma - Create Migration File

	cmd: dotnet ef migrations add [Filename]  
(dotnet ef migrations add MyMigration)
	
Veritabanı Aktarım Komutu - Database Migration Command:

	cmd: dotnet ef database update
	
.
