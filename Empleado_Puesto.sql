GO
ALTER Procedure [dbo].[sp_ConsultarEmpleado]
as
begin

Select * from tbl_Empleado

end--Fin sp_ConsultarEmpleado
GO

CREATE PROCEDURE [dbo].[sp_ConsultarEmpleadoEspecifico]
(
@Consulta VARCHAR(50)
)
AS
BEGIN

SELECT * FROM tbl_Empleado WHERE vrch_Nombre LIKE '%'+@Consulta+'%'
OR vrch_Apellido1 LIKE '%'+@Consulta+'%' OR vrch_Apellido2 LIKE '%'+@Consulta+'%'
OR vrch_Cedula LIKE '%'+@Consulta+'%'

END--Fin sp_ConsultarEmpleado


GO