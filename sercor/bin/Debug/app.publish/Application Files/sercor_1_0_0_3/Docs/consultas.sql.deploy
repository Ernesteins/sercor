use sercorDB;
select * from sercordb.abono LIMIT100;
select * from sercordb.caja LIMIT100;
select * from sercordb.cambio_precios LIMIT100;
select * from sercordb.cliente LIMIT100;
select * from sercordb.cuenta LIMIT100;
select * from sercordb.detalle LIMIT100;
select * from sercordb.egresos LIMIT100;
select * from sercordb.factura LIMIT100;
select * from sercordb.producto LIMIT100;
select * from sercordb.trabajos LIMIT100;
select * from sercordb.usuario LIMIT100;

/*Seleccionar la fecha y hora actuales*/
SELECT NOW();
select * from SERCORDB.trabajos;

/*INSERCIONES INICIALES*/
/*insert into sercordb.usuario values(001, 1, 'Ernesteins','03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4','Ernesto','Yaselga','1725158123','Dos Puentes','0995193611',15,15);*/
insert into sercordb.usuario values(000, 0, 'ADMIN','a82a8f1fd4ef1f2e42a0798868f8445ff9f524bfb6df460fb256f84ee8588e1b','Administrador','del sistema','0000000001','-Sercor-','0000000000',15,15);
insert into sercordb.producto values ("L01","prod_1","LUNA|descripcion de producto luna","luna_pruebas","lune_pruebas","100","49.50","1");
insert into sercordb.producto values ("A02","prod_2","ARMA|descripcion de producto armazon","armazon_pruebas","armazon_pruebas","100","99.99","1");


/*Creación y edición de privilegios al sercoruser*/
CREATE USER 'sercoruser'@'localhost' IDENTIFIED BY 'S3rc0r';
grant DELETE, INSERT, SELECT, UPDATE on caja	 to 'sercoruser'@'localhost';
grant DELETE, INSERT, SELECT, UPDATE on cambio_precios	 to 'sercoruser'@'localhost';
grant DELETE, INSERT, SELECT, UPDATE on cliente	 to 'sercoruser'@'localhost';
grant DELETE, INSERT, SELECT, UPDATE on cuenta	 to 'sercoruser'@'localhost';
grant DELETE, INSERT, SELECT, UPDATE on detalle	 to 'sercoruser'@'localhost';
grant DELETE, INSERT, SELECT, UPDATE on egreso	 to 'sercoruser'@'localhost';
grant DELETE, INSERT, SELECT, UPDATE on factura	 to 'sercoruser'@'localhost';
grant DELETE, INSERT, SELECT, UPDATE on producto to 'sercoruser'@'localhost';
grant DELETE, INSERT, SELECT, UPDATE on trabajos to 'sercoruser'@'localhost';
grant DELETE, INSERT, SELECT, UPDATE on usuario	 to 'sercoruser'@'localhost';
grant DELETE, INSERT, SELECT, UPDATE on producto_vendido to 'sercoruser'@'localhost';
grant INSERT, SELECT on pago to 'sercoruser'@'localhost';


/*CONSULTAS DE REPORTES*/
INVENTARIO :  "select IDREGISTRO, FECHA, registro_inventario.ID_PRODUCTO, ID_PRODUCTOINVENTARIO, registro_inventario.CANTIDAD from registro_inventario, producto_vendido where ID_PRODUCTO_V = producto_vendido.ID_PRODUCTO;"
FACTURACION:  "select TIPO AS TIPO_DE_DOCUMENTO, ID_FACTURA AS ID_DOCUMENTO, ID_CLIENTE, ID_USUARIO, IVA, TOTAL, FECHA FROM FACTURA;"
MOVIMIENTO DE CAJA: /*2 secciones*/ /*-ingresos arriba*/"select * pago" /*-egresos abajo*/"select * from egresos"