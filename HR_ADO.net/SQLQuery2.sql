CREATE PROCEDURE [dbo].[@INSERT]
  @Id		INT,
  @Name     NVARCHAR(Max),            
  @Salary   NVARCHAR(Max),                 
  @Gender   NVARCHAR(Max),                 
  @Address  NVARCHAR(Max)                   
AS
BEGIN
INSERT INTO dbo.Employee(Id,Name,Salary,Gender,Address)  VALUES(@Id,@Name,@Salary,@Gender,@Address)
END