DECLARE @Name INT;
SET @Name = 2235;  -- Use the actual ID you want to check

SELECT * FROM Test WHERE Name = @Name;