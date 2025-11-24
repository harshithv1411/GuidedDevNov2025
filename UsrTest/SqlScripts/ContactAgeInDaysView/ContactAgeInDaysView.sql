Create or alter view UsrVwContactAgeDays
as
select Id as UsrId , Name as UsrName , BirthDate as UsrBirthDate,
datediff(day , Birthdate, getdate()) as UsrAgeDays
from Contact 