create database rekammedis

use rekammedis

create table Pasien(
NoPasien CHAR (6) NOT NULL PRIMARY KEY,
NamaPasien VARCHAR (20) NOT NULL,
JenisKelamin VARCHAR (10) NOT NULL,
Agama VARCHAR (10) NOT NULL,
Alamat VARCHAR (30) NOT NULL,
Tgl VARCHAR(15) NOT NULL,
Telepon CHAR (14) NOT NULL,
Tb CHAR (3) NOT NULL,
Bb CHAR (3) NOT NULL,
Alergi VARCHAR (20) NOT NULL,
Pekerjaan VARCHAR (20) NOT NULL,
NamaKK VARCHAR (20) NOT NULL,
);

select * from Pasien;

create table Dokter(
IdDokter CHAR (15) NOT NULL PRIMARY KEY,
NamaDokter VARCHAR (20) NOT NULL,
Alamat VARCHAR (30) NOT NULL,
Telepon CHAR (14) NOT NULL,
JenisKelamin VARCHAR (10) NOT NULL,
NoPraktek CHAR (12) NOT NULL,
);

select * from Dokter;

create table Poli(
KodePoli CHAR (5) NOT NULL PRIMARY KEY,
NamaPoli VARCHAR (10) NOT NULL,
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

select * from Obat;

create table RekamMedis(
NoRekam CHAR (15) NOT NULL PRIMARY KEY,
NoPasien CHAR (6) NOT NULL CONSTRAINT FK_Pasien FOREIGN KEY (NoPasien) REFERENCES Pasien(NoPasien),
NamaPasien VARCHAR (20) NOT NULL,
JenisKelamin VARCHAR (10) NOT NULL,
Alamat VARCHAR (30) NOT NULL,
Alergi VARCHAR (20) NOT NULL,
IdDokter CHAR (15) NOT NULL CONSTRAINT FK_Dokter FOREIGN KEY (IdDokter) REFERENCES Dokter(IdDokter),
NamaDokter VARCHAR (20) NOT NULL,
KodePoli CHAR (5) NOT NULL CONSTRAINT FK_Poli FOREIGN KEY (KodePoli) REFERENCES Poli(KodePoli),
NamaPoli VARCHAR (10) NOT NULL,
KodeObat CHAR (15) NOT NULL CONSTRAINT FK_Obat FOREIGN KEY (KodeObat) REFERENCES Obat(KodeObat),
NamaObat VARCHAR (20) NOT NULL,
HasilPemeriksaan VARCHAR (200) NOT NULL,
);

select * from RekamMedis;

create table Pembayaran(
NoRegristrasi CHAR (15) NOT NULL PRIMARY KEY,
NoRekam CHAR (15) NOT NULL CONSTRAINT FK_RekamMedis FOREIGN KEY (NoRekam) REFERENCES RekamMedis(NoRekam),
NamaPasien VARCHAR (20) NOT NULL,
NamaPoli VARCHAR (10) NOT NULL,
NamaObat VARCHAR (20) NOT NULL,
Harga VARCHAR (15) NOT NULL,
Asuransi VARCHAR (10) NOT NULL,
);

select * from Pembayaran;