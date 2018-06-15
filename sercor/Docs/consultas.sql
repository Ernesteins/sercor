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

/*EDICION DE CLAVES Y TABLAS ERRONEAS*/
Alter TABLE sercorDB.cliente MODIFY ID_CLIENTE CHAR(32);
Alter TABLE sercorDB.usuario MODIFY CONTRASENA char varying(64);
ALTER TABLE sercordb.cliente DROP APELLIDO;
ALTER TABLE sercordb.cliente MODIFY NOMBRE char varying(100);

Alter TABLE sercorDB.caja MODIFY FECHA datetime;
Alter TABLE sercorDB.cambio_precios MODIFY FECHA_CAMBIO datetime;
Alter TABLE sercorDB.egresos MODIFY FECHA datetime;
Alter TABLE sercorDB.factura MODIFY FECHA datetime;
Alter TABLE sercorDB.trabajos MODIFY FECHA_INICIO datetime;
Alter TABLE sercorDB.trabajos MODIFY FECHA_ENTREGA datetime;
Alter TABLE sercorDB.abono MODIFY FECHA datetime;


Alter TABLE sercordb.producto drop foreign key FK_PRODUCTO_DETALLE_P_DETALLE;
drop index DETALLE_PROD_FK on sercordb.producto;
Alter TABLE sercordb.producto drop ID_DETALLE;

alter table sercordb.factura drop foreign key  FK_FACTURA_FACT_DETA_DETALLE;
drop index FACT_DETALLE2_FK ON sercordb.factura;
Alter table sercordb.factura drop ID_DETALLE;

alter table sercordb.factura drop foreign key  FK_FACTURA_FACTURA_T_TRABAJOS;
drop index FACTURA_TRABAJOS2_FK ON sercordb.factura;
Alter table sercordb.factura drop ID_TRABAJO;

alter table sercordb.trabajos drop foreign key  FK_TRABAJOS_CUENTA_T_CUENTA;
drop index CUENTA_TRABAJOS_FK ON sercordb.trabajos;
Alter table sercordb.trabajos drop ID_CUENTA;

alter table sercordb.cuenta drop foreign key  FK_CUENTA_CUENTA_C_CAJA;
Alter table sercordb.cuenta drop ID_CAJA;

alter table sercordb.detalle  add ID_PRODUCTO int(11);
create  index PROD_DETALLE_FK on DETALLE (ID_PRODUCTO);
alter table DETALLE add constraint FK_DETALLE_CT_PRODUCTO_T foreign key (ID_PRODUCTO) references producto (ID_PRODUCTO) on delete restrict on update restrict;

alter table sercordb.cuenta add ID_FACTURA int(11);
create  index CUENTA_FACTURA_FK on CUENTA (ID_FACTURA);
alter table CUENTA add constraint FK_CUENTA_CUENTA_F_FACTURA foreign key (ID_FACTURA) references FACTURA (ID_FACTURA) on delete restrict on update restrict;

alter table sercordb.factura drop foreign key  FK_FACTURA_FACT_CUEN_CUENTA;
drop index FACT_CUENTA_FK ON sercordb.factura;
Alter table sercordb.factura drop ID_CUENTA;


/*INSERCIONES*/

insert into sercordb.usuario values(001, 1, 'Ernesteins','d441d1ee788fc1ffb199621a2e47f88f74ac2eda4598abbdd1c3deb965b94d9d','Ernesto','Yaselga','1725158123','Dos Puentes','0995193611',0,0);
insert into cliente values("1725158123","Ernesto Yaselga_cli","DOS PUENTES","0995193611");
insert into sercordb.producto values ("001","prod_1","producto 1 de las pruebas","pruebas","pruebas","100","99.99","1");
insert into sercordb.producto values ("002","prod_2","producto 2 de las pruebas","pruebas","pruebas","100","99.99","1");
insert into sercordb.factura values ("001","1725158123","001",0,0,(SELECT NOW()));