create database rekammedis

use rekammedis

create table Pasien(
NoPasien CHAR (6) NOT NULL PRIMARY KEY,
NamaPasien VARCHAR (20) NOT NULL,
JenisKelamin VARCHAR (10) NOT NULL,
Agama VARCHAR (10) NOT NULL,
Alamat VARCHAR (30) NOT NULL,
Tgl datetime NOT NULL,
Telepon CHAR (14) NOT NULL,
Tb CHAR (3) NOT NULL,
Bb CHAR (3) NOT NULL,
Alergi VARCHAR (20) NOT NULL,
Pekerjaan VARCHAR (20) NOT NULL,
NamaKK VARCHAR (20) NOT NULL,
);

create proc SP_Pasien_Insert
@NoPasien CHAR (6),
@NamaPasien VARCHAR (20),
@JenisKelamin VARCHAR (10),
@Agama VARCHAR (10),
@Alamat VARCHAR (30),
@Tgl datetime,
@Telepon CHAR (14),
@Tb CHAR (3),
@Bb CHAR (3),
@Alergi VARCHAR (20),
@Pekerjaan VARCHAR (20),
@NamaKK VARCHAR (20)
as
begin
insert into Pasien (NoPasien,NamaPasien,JenisKelamin,Agama,Alamat,Tgl,Telepon,Tb,Bb,Alergi,Pekerjaan,NamaKK) values
(@NoPasien,@NamaPasien,@JenisKelamin,@Agama,@Alamat,@Tgl,@Telepon,@Tb,@Bb,@Alergi,@Pekerjaan,@NamaKK)
end

create proc SP_Pasien_View
as
begin
select * from Pasien
end

create proc SP_Pasien_Update
@NoPasien CHAR (6),
@NamaPasien VARCHAR (20),
@JenisKelamin VARCHAR (10),
@Agama VARCHAR (10),
@Alamat VARCHAR (30),
@Tgl datetime,
@Telepon CHAR (14),
@Tb CHAR (3),
@Bb CHAR (3),
@Alergi VARCHAR (20),
@Pekerjaan VARCHAR (20),
@NamaKK VARCHAR (20)
as
begin
Update Pasien set NamaPasien=@NamaPasien,JenisKelamin=@JenisKelamin,Agama=@Agama,Alamat=@Alamat,Tgl=@Tgl,Telepon=@Telepon,Tb=@Tb,Bb=@Bb,Alergi=@Alergi,Pekerjaan=@Pekerjaan,NamaKK=@NamaKK where NoPasien=@NoPasien
end

create proc SP_Pasien_Delete
@NoPasien CHAR (6)
as
begin
Delete Pasien where NoPasien=@NoPasien
end

create proc SP_Pasien_Search
@NoPasien CHAR (6)
as
begin
select * from Pasien where NoPasien=@NoPasien
end

select * from Pasien;

create table Dokter(
IdDokter CHAR (15) NOT NULL PRIMARY KEY,
NamaDokter VARCHAR (20) NOT NULL,
Alamat VARCHAR (30) NOT NULL,
Telepon CHAR (14) NOT NULL,
JenisKelamin VARCHAR (20) NOT NULL,
NoPraktek CHAR (12) NOT NULL,
);

create proc SP_Dokter_Insert
@IdDokter CHAR (15),
@NamaDokter VARCHAR (20),
@Alamat VARCHAR (30),
@Telepon CHAR (14),
@JenisKelamin VARCHAR (20),
@NoPraktek CHAR (12)
as
begin
insert into Dokter (IdDokter,NamaDokter,Alamat,Telepon,JenisKelamin,NoPraktek) values
(@IdDokter,@NamaDokter,@Alamat,@Telepon,@JenisKelamin,@NoPraktek)
end

create proc SP_Dokter_View
as
begin
select * from Dokter
end

create proc SP_Dokter_Update
@IdDokter CHAR (15),
@NamaDokter VARCHAR (20),
@Alamat VARCHAR (30),
@Telepon CHAR (14),
@JenisKelamin VARCHAR (20),
@NoPraktek CHAR (12)
as
begin
Update Dokter set NamaDokter=@NamaDokter,Alamat=@Alamat,Telepon=Telepon,JenisKelamin=@JenisKelamin,NoPraktek=@NoPraktek where IdDokter=@IdDokter
end

create proc SP_Dokter_Delete
@IdDokter CHAR (6)
as
begin
Delete Dokter where IdDokter=@IdDokter
end

create proc SP_Dokter_Search
@IdDokter CHAR (6)
as
begin
select * from Dokter where IdDokter=@IdDokter
end

select * from Dokter;

create table Poli(
KodePoli CHAR (5) NOT NULL PRIMARY KEY,
NamaPoli VARCHAR (15) NOT NULL,
);

select * from Poli;

create table Obat(
KodeObat CHAR (15) NOT NULL PRIMARY KEY,
NamaObat VARCHAR (20) NOT NULL,
Spesifikasi VARCHAR (15) NOT NULL,
Keterangan VARCHAR (30) NOT NULL,
Satuan VARCHAR (10) NOT NULL,
Harga VARCHAR (15) NOT NULL,
Stok CHAR (5) NOT NULL,
);

create proc SP_Obat_Insert
@KodeObat CHAR (15),
@NamaObat VARCHAR (20),
@Spesifikasi VARCHAR (15),
@Keterangan VARCHAR (30),
@Satuan VARCHAR (10),
@Harga VARCHAR (15),
@Stok CHAR (5)
as
begin
insert into Obat (KodeObat,NamaObat,Spesifikasi,Keterangan,Satuan,Harga,Stok) values
(@KodeObat,@NamaObat,@Spesifikasi,@Keterangan,@Satuan,@Harga,@Stok)
end

create proc SP_Obat_View
as
begin
select * from Obat
end

create proc SP_Obat_Update
@KodeObat CHAR (15),
@NamaObat VARCHAR (20),
@Spesifikasi VARCHAR (15),
@Keterangan VARCHAR (30),
@Satuan VARCHAR (10),
@Harga VARCHAR (15),
@Stok CHAR (5)
as
begin
Update Obat set NamaObat=@NamaObat,Spesifikasi=@Spesifikasi,Keterangan=@Keterangan,Satuan=@Satuan,Harga=@Harga,Stok=@Stok where KodeObat=@KodeObat
end

create proc SP_Obat_Delete
@KodeObat CHAR (6)
as
begin
Delete Obat where KodeObat=@KodeObat
end

create proc SP_Obat_Search
@KodeObat CHAR (6)
as
begin
select * from Obat where KodeObat=@KodeObat
end


select * from Obat;

create table RekamMedis(
NoRekam CHAR (15) NOT NULL PRIMARY KEY,
NoPasien CHAR (6) NOT NULL CONSTRAINT FK_Pasien FOREIGN KEY (NoPasien) REFERENCES Pasien(NoPasien),
Hasil VARCHAR (500) NOT NULL,
);
select * from RekamMedis;

create table detailrekam(
IdDetaiRekam CHAR (20) NOT NULL PRIMARY KEY,
NoRekam CHAR (15) NOT NULL CONSTRAINT FK_RekamMedis FOREIGN KEY (NoRekam) REFERENCES RekamMedis(NoRekam),
KodeObat CHAR (15) NOT NULL CONSTRAINT FK_Obat FOREIGN KEY (KodeObat) REFERENCES Obat(KodeObat),
KodePoli CHAR (5) NOT NULL CONSTRAINT FK_Poli FOREIGN KEY (KodePoli) REFERENCES Poli(KodePoli),
IdDokter CHAR (15) NOT NULL CONSTRAINT FK_Dokter FOREIGN KEY (IdDokter) REFERENCES Dokter(IdDokter),
);

select * from detailrekam;

create table Pembayaran(
NoRegristrasi CHAR (15) NOT NULL PRIMARY KEY,
IdDetaiRekam CHAR (20) NOT NULL CONSTRAINT FK_RekamMedis FOREIGN KEY (NoRekam) REFERENCES RekamMedis(NoRekam),
NamaPasien VARCHAR (20) NOT NULL,
NamaPoli VARCHAR (10) NOT NULL,
NamaObat VARCHAR (20) NOT NULL,
Harga VARCHAR (15) NOT NULL,
Asuransi VARCHAR (10) NOT NULL,
);

select * from Pembayaran;