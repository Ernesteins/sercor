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

Alter TABLE sercorDB.cliente MODIFY ID_CLIENTE int(32);
Alter TABLE sercorDB.usuario MODIFY CONTRASENA char varying(64);
ALTER TABLE sercordb.cliente DROP APELLIDO;
ALTER TABLE sercordb.cliente MODIFY NOMBRE char varying(100);

insert into sercordb.usuario values(001, 1, 'Ernesteins','d441d1ee788fc1ffb199621a2e47f88f74ac2eda4598abbdd1c3deb965b94d9d','Ernesto','Yaselga','1725158123','Dos Puentes','0995193611',0,0);