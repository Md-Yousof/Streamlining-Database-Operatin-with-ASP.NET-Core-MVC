use master
Create database CoreMonthlyEvi
Go

use CoreMonthlyEvi
Create Table CustomerInfo
(
Id int Primary key Identity(1,1),
CustoName varchar(30),
CustoAddress varchar(50),
PhoneNo int,
Age int,
Salary decimal,
DateOfB date
);
Go

--Create StorProcedure---

Create proc sp_CreateCustomer
@custoName varchar(30),
@custoAddress varchar(50),
@phoneNo int,
@age int,
@salary decimal,
@dateOfB date
AS
Begin
	Insert Into CustomerInfo (CustoName,CustoAddress,PhoneNo,Age,Salary,DateOfB)
	Values (@custoName,@custoAddress,@phoneNo,@age,@salary,@dateOfB)
End
Go


Create proc sp_UpdateCustomer
@id int,
@custoName varchar(30),
@custoAddress varchar(50),
@phoneNo int,
@age int,
@salary decimal,
@dateOfB date
AS
Begin
	Update  CustomerInfo
	Set CustoName=@custoName,CustoAddress=@custoAddress,PhoneNo=@phoneNo,Age=@age,Salary=@salary,DateOfB=@dateOfB
	Where Id=@id
End
Go


Create proc sp_DeleteCustomer
@id int
As
Begin
	Delete from CustomerInfo
	where Id = @id
End
Go

Create proc sp_GetAllCustomer
As
Begin
	Select* from CustomerInfo
End
Go

Create proc sp_GetByIdCustomer
@id int
As
Begin
	Select* from CustomerInfo
	where Id = @id
End
Go







