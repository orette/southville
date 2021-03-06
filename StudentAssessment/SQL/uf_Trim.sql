IF EXISTS (SELECT NAME FROM sysobjects
WHERE NAME = N'uf_Trim'
AND TYPE='FN')
DROP FUNCTION uf_Trim
GO

CREATE FUNCTION uf_Trim(@string VARCHAR(MAX))
RETURNS VARCHAR(MAX)

BEGIN
RETURN LTRIM(RTRIM(@string))
END
GO


GRANT EXECUTE, REFERENCES ON uf_Trim TO DYNGRP;

GO