

use Pasien

CREATE TABLE pasien(
nopasien VARCHAR (6) NOT NULL PRIMARY KEY,
namapasien VARCHAR (20) NOT NULL,
jeniskelamin VARCHAR (10) NOT NULL,
agama VARCHAR (10) NOT NULL,
alamat VARCHAR (30) NOT NULL,
tgl VARCHAR (15) NOT NULL,
telepon CHAR (13) NOT NULL,
tb CHAR (3) NOT NULL,
bb CHAR (3) NOT NULL,
alergi VARCHAR (25) NOT NULL,
pekerjaan VARCHAR (20) NOT NULL,
namakk VARCHAR (25) NOT NULL,
);

select * from pasien;

CREATE TABLE dokter(
iddokter VARCHAR (10) NOT NULL PRIMARY KEY,
namadokter VARCHAR (25) NOT NULL,
alamat VARCHAR (30) NOT NULL,
telepon CHAR (13) NOT NULL,
jeniskelamin VARCHAR (10) NOT NULL,
nopraktek CHAR (15) NOT NULL,
);

select * from dokter;

CREATE TABLE kelas(
idkelas VARCHAR (5) NOT NULL PRIMARY KEY,
namakelas VARCHAR (10) NOT NULL,
harga INT NOT NULL,
);

select * from kelas;

CREATE TABLE poli(
kodepoli VARCHAR (5) NOT NULL PRIMARY KEY,
namapoli VARCHAR (10) NOT NULL,
);

select * from poli;

CREATE TABLE obat(
kodeobat VARCHAR (10) NOT NULL PRIMARY KEY,
namaobat VARCHAR (25) NOT NULL,
spesifikasi VARCHAR (30) NOT NULL,
keterangan VARCHAR (13) NOT NULL,
satuan VARCHAR (10) NOT NULL,
harga CHAR (15) NOT NULL,
stok CHAR (4) NOT NULL,
);

select * from obat;

CREATE TABLE registrasi(
noregistrasi CHAR (10) NOT NULL PRIMARY KEY,
norekam CHAR (10) NOT NULL,
namapasien VARCHAR (20) NOT NULL,
alamat VARCHAR (30) NOT NULL,
kodepoli VARCHAR (5) NOT NULL,
namapoli VARCHAR (10) NOT NULL,
);

select * from obat;

CREATE TABLE pembayaran(
idpembayaran VARCHAR (10) NOT NULL PRIMARY KEY,
tglpembayaran CHAR (10) NOT NULL,
nopasien VARCHAR (6) NOT NULL, CONSTRAINT FK_PASIEN FOREIGN KEY (nopasien) REFERENCES pasien(nopasien)
);

select * from pembayaran;

CREATE TABLE totalpembayaran(
idpembayaran VARCHAR (10) NOT NULL,
idkelas VARCHAR (5) NOT NULL,
CONSTRAINT FK_PEMBAYARAN FOREIGN KEY (idpembayaran) REFERENCES pembayaran(idpembayaran),
CONSTRAINT FK_KELAS FOREIGN KEY (idkelas) REFERENCES kelas(idkelas)
);

select * from totalpembayaran;