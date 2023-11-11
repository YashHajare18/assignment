CREATE PROCEDURE [dbo].[@UPDATE]
  @Id		INT,
  @Name     NVARCHAR(Max),            
  @Salary   NVARCHAR(Max),                 
  @Gender   NVARCHAR(Max),                 
  @Address  NVARCHAR(Max)                   
AS
BEGIN
UPDATE dbo.Employee SET Id=@Id,Name=@Name,Salary=@Salary,Gender=@Gender,Address=@Address 
WHERE Id=@Id
END