create database SocialWeb
use SocialWeb

create table Roles (
	idRole int primary key identity,
	RoleName nvarchar(50) not null
)

create table Users(
	idUser int primary key identity,
	Name nvarchar(50) not null,
	Surname nvarchar(50) not null,
	LastName nvarchar(50) null,
	DataBirthDay date null,
	PhoneNumber nvarchar(20) not null,
	Email nvarchar(100) null,
	Password nvarchar(100) not null,
	RoleId int foreign key references Roles(idRole)
)
alter table Users add ImageUser image null
select * from Users

create table Posts (
	idPost int primary key identity,
	TextPost text not null,
	ImagePost image,
	MusicPath nvarchar(max),
	VideoPath nvarchar(max),
	idUser int foreign key references Users(idUser)
)

create table DialogType (
	idType int primary key identity,
	TypeName nvarchar(50)
)

create table Dialog(
	idDialog int primary key identity,
	Name nvarchar(50) not null,
	IdType int foreign key references DialogType(idType)
)

create table DialogUsers (
	idDialogUser int primary key identity,
	idUser int foreign key references Users(idUser),
	idDialog int foreign key references Dialog(idDialog)
)

create table DialogMessage (
	idMessage int primary key identity,
	TextSender text not null,
	DateOfSender datetime not null,
	idDialog int foreign key references Dialog(idDialog),
	idUser int foreign key references Users(idUser) 
)








insert into Roles(RoleName)
values ('Администратор'),
	   ('Пользователь')