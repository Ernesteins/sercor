/*==============================================================*/
/* DBMS name:      PostgreSQL 9.x                               */
/* Created on:     9/6/2018 20:04:07                            */
/*==============================================================*/
drop database sercorDB;
create database sercorDB;
use sercorDB;
/*==============================================================*/
/* Table: CAJA                                                  */
/*==============================================================*/
create table CAJA (
   ID_CAJA              INT4                 not null,
   TIPO                 INT2                 not null,
   FECHA                DATETIME                 not null,
   DESCRIPCION          CHAR(128)            not null,
   MONTO                FLOAT(12,2)          not null,
   constraint PK_CAJA primary key (ID_CAJA)
);

/*==============================================================*/
/* Index: CAJA_PK                                               */
/*==============================================================*/
create unique index CAJA_PK on CAJA (
ID_CAJA
);

/*==============================================================*/
/* Table: CAMBIO_PRECIOS                                        */
/*==============================================================*/
create table CAMBIO_PRECIOS (
   ID_CAMBIO            INT4                 not null,
   ID_PRODUCTO          CHAR(16)                 null,
   FECHA_CAMBIO         DATETIME                 not null,
   VALOR_VIEJO          FLOAT(12,2)          not null,
   VALOR_NUEVO          FLOAT(12,2)          not null,
   CODIGO_PRODUCTO      CHAR(32)             not null,
   constraint PK_CAMBIO_PRECIOS primary key (ID_CAMBIO)
);

/*==============================================================*/
/* Index: CAMBIO_PRECIOS_PK                                     */
/*==============================================================*/
create unique index CAMBIO_PRECIOS_PK on CAMBIO_PRECIOS (
ID_CAMBIO
);

/*==============================================================*/
/* Index: PROD_CAMBIOPRECIOS_FK                                 */
/*==============================================================*/
create  index PROD_CAMBIOPRECIOS_FK on CAMBIO_PRECIOS (
ID_PRODUCTO
);

/*==============================================================*/
/* Table: CLIENTE                                               */
/*==============================================================*/
create table CLIENTE (
   ID_CLIENTE           CHAR(32)                 not null,
   NOMBRE               CHAR(100)             not null,
   /*APELLIDO             CHAR(50)             not null,*/
   DIRECCION            CHAR(128)            not null,
   TELEFONO             CHAR(32)             not null,
   constraint PK_CLIENTE primary key (ID_CLIENTE)
);

/*==============================================================*/
/* Index: CLIENTE_PK                                            */
/*==============================================================*/
create unique index CLIENTE_PK on CLIENTE (
ID_CLIENTE
);


/*==============================================================*/
/* Table: CUENTA                                   Quitar caja            */
/*==============================================================*/
create table CUENTA (
   ID_CUENTA            INT4                 not null,
   ID_CLIENTE           CHAR(32)                 null,
   ID_FACTURA           INT4                 null,
   /*ID_CAJA              INT4                 null, */
   ID_TRABAJO           INT4                 null,
   TOTAL                FLOAT(12,2)          not null,
   FORMA_PAGO           INT2                 not null,
   SALDO                FLOAT(12,2)          not null,
   ESTADO_P             BOOL                 not null,
   constraint PK_CUENTA primary key (ID_CUENTA)
);


/*==============================================================*/
/* Index: CUENTA_PK                                            */
/*==============================================================*/
create unique index CUENTA_PK on CUENTA (
ID_CUENTA
);

/*==============================================================*/
/* Index: CUENTA_CLIENTES_FK                                   */
/*==============================================================*/
create  index CUENTA_CLIENTES_FK on CUENTA (
ID_CLIENTE
);

/*==============================================================*/
/* Index: CUENTA_FACTURA_FK                                       */
/*==============================================================*/
create  index CUENTA_FACTURA_FK on CUENTA (
ID_FACTURA
);

/*==============================================================*/
/* Index: CUENTA_TRABAJOS2_FK                                  */
/*==============================================================*/
create  index CUENTA_TRABAJOS2_FK on CUENTA (
ID_TRABAJO
);

/*==============================================================*/
/* Table: DETALLE                                               */
/*==============================================================*/
create table DETALLE (
   ID_DETALLE           INT4                 not null,
   ID_FACTURA           INT4                 null,
   ID_PRODUCTO          CHAR(16)                 not null,
   CANTIDAD             FLOAT(12,2)          not null,
   SUBTOTAL             FLOAT(12,2)          not null,
   
   constraint PK_DETALLE primary key (ID_DETALLE)
);

/*==============================================================*/
/* Index: DETALLE_PK                                            */
/*==============================================================*/
create unique index DETALLE_PK on DETALLE (
ID_DETALLE
);

/*==============================================================*/
/* Index: FACT_DETALLE_FK                                       */
/*==============================================================*/
create  index FACT_DETALLE_FK on DETALLE (
ID_FACTURA
);

/*==============================================================*/
/* Index: PROD_DETALLE_FK                                       */
/*==============================================================*/
create  index PROD_DETALLE_FK on DETALLE (
ID_PRODUCTO
);


/*==============================================================*/
/* Table: EGRESOS                                               */
/*==============================================================*/
create table EGRESOS (
   ID_EGRESO            INT4                 not null,
   ID_CAJA              INT4                 null,
   FECHA                DATETIME                 not null,
   DESCUENTO            FLOAT(12,2)          not null,
   MONTO                FLOAT(12,2)          not null,
   constraint PK_EGRESOS primary key (ID_EGRESO)
);

/*==============================================================*/
/* Index: EGRESOS_PK                                            */
/*==============================================================*/
create unique index EGRESOS_PK on EGRESOS (
ID_EGRESO
);

/*==============================================================*/
/* Index: CAJA_EGRESOS_FK                                       */
/*==============================================================*/
create  index CAJA_EGRESOS_FK on EGRESOS (
ID_CAJA
);

/*==============================================================*/
/* Table: FACTURA                                               */
/*==============================================================*/
create table FACTURA (
   ID_FACTURA           INT4                 not null,
   ID_CLIENTE           CHAR(32)                null,
   ID_USUARIO           INT4                 null,
   /*ID_DETALLE           INT4                 null,*/
   /*ID_CUENTA            INT4                 null,*/
   /*ID_TRABAJO           INT4                 null,*/
   IVA                  FLOAT(12,2)          not null,
   TOTAL                FLOAT(12,2)          not null,
   FECHA                DATETIME                 not null,
   FACTOR_DESCUENTO     FLOAT(12,2)          not null,
   VALOR_DESCONTADO     FLOAT(12,2)          not null,
   constraint PK_FACTURA primary key (ID_FACTURA)
);

/*==============================================================*/
/* Index: FACTURA_PK                                            */
/*==============================================================*/
create unique index FACTURA_PK on FACTURA (
ID_FACTURA
);

/*==============================================================*/
/* Index: FACT_CLIENTE_FK                                       */
/*==============================================================*/
create  index FACT_CLIENTE_FK on FACTURA (
ID_CLIENTE
);

/*==============================================================*/
/* Index: FACT_USUARIO_FK                                       */
/*==============================================================*/
create  index FACT_USUARIO_FK on FACTURA (
ID_USUARIO
);

/*==============================================================*/
/* Index: FACT_DETALLE2_FK                                      */
/*==============================================================*/
/*create  index FACT_DETALLE2_FK on FACTURA ( 
ID_DETALLE
);*/

/*==============================================================*/
/* Index: FACT_CUENTA_FK                                       */
/*==============================================================*/
/*create  index FACT_CUENTA_FK on FACTURA (
ID_CUENTA
);*/

/*==============================================================*/
/* Index: FACTURA_TRABAJOS2_FK                                  */
/*==============================================================*/
/*create  index FACTURA_TRABAJOS2_FK on FACTURA (
ID_TRABAJO
);*/

/*==============================================================*/
/* Table: PRODUCTO                                              */
/*==============================================================*/
create table PRODUCTO (
   ID_PRODUCTO          CHAR(16)                 not null,
   /*ID_DETALLE           INT4                 null,*/
   NOMBRE               CHAR(50)             not null,
   DESCRIPCION          CHAR(128)            not null,
   CATEGORIA            CHAR(32)             not null,
   SUBCATEGORIA         CHAR(32)             not null,
   EXISTENCIA           INT4                 not null,
   PRECIO               FLOAT(12,2)          not null,
   ESTADO               INT2                 not null,
   constraint PK_PRODUCTO primary key (ID_PRODUCTO)
);

/*==============================================================*/
/* Index: PRODUCTO_PK                                           */
/*==============================================================*/
create unique index PRODUCTO_PK on PRODUCTO (
ID_PRODUCTO
);

/*==============================================================*/
/* Index: DETALLE_PROD_FK                                       */
/*==============================================================*/
/*create  index DETALLE_PROD_FK on PRODUCTO (
ID_DETALLE
);*/

/*==============================================================*/
/* Table: TRABAJOS                              Quitar cuenta                */
/*==============================================================*/
create table TRABAJOS (
   ID_TRABAJO           INT4                 not null,
   ID_CUENTA            INT4                 null,
   ID_FACTURA           INT4                 null,
   FECHA_INICIO         DATETIME                 not null,
   NOMBRE_CL            CHAR(32)             not null,
   ARMAZON              CHAR(32)             not null,
   LUNA                 CHAR(32)             not null,
   ESTADO               INT2                 not null,
   FECHA_ENTREGA        DATETIME                 not null,
   constraint PK_TRABAJOS primary key (ID_TRABAJO)
);

/*==============================================================*/
/* Index: TRABAJOS_PK                                           */
/*==============================================================*/
create unique index TRABAJOS_PK on TRABAJOS (
ID_TRABAJO
);

/*==============================================================*/
/* Index: CUENTA_TRABAJOS_FK                                   */
/*==============================================================*/
create  index CUENTA_TRABAJOS_FK on TRABAJOS (
ID_CUENTA
);

/*==============================================================*/
/* Index: FACTURA_TRABAJOS_FK                                   */
/*==============================================================*/
create  index FACTURA_TRABAJOS_FK on TRABAJOS (
ID_FACTURA
);

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO (
   ID_USUARIO           INT4                 not null,
   TIPO                 INT2                 not null,
   USUARIO              CHAR(32)             not null,
   CONTRASENA           CHAR(64)             not null,
   NOMBRE               CHAR(50)             not null,
   APELLIDO             CHAR(50)             not null,
   CEDULA               CHAR(10)             not null,
   DIRECCION            CHAR(128)            not null,
   TELEFONO             CHAR(32)             not null,
   PRIVILEGIO1          BOOL                 null,
   PRIVILEGIO2          BOOL                 null,
   constraint PK_USUARIO primary key (ID_USUARIO)
);

/*==============================================================*/
/* Index: USUARIO_PK                                            */
/*==============================================================*/
create unique index USUARIO_PK on USUARIO (
ID_USUARIO
);

/*==============================================================*/
/* Table: ABONO                                               */
/*==============================================================*/

create table ABONO(
   ID_CUENTA            INT4                 NOT null,
   FECHA                DATETIME                 not null,
   MONTO                FLOAT(12,2)          not null,
   primary key (ID_CUENTA,FECHA)
);

alter table CAMBIO_PRECIOS
   add constraint FK_CAMBIO_P_PROD_CAMB_PRODUCTO foreign key (ID_PRODUCTO)
      references PRODUCTO (ID_PRODUCTO)
      on delete restrict on update restrict;

alter table CUENTA
   add constraint FK_CUENTA_CUENTA_F_FACTURA foreign key (ID_FACTURA)
      references FACTURA (ID_FACTURA)
      on delete restrict on update restrict;

alter table CUENTA
   add constraint FK_CUENTA_CUENTA_C_CLIENTE foreign key (ID_CLIENTE)
      references CLIENTE (ID_CLIENTE)
      on delete restrict on update restrict;

alter table CUENTA
   add constraint FK_CUENTA_CUENTA_T_TRABAJOS foreign key (ID_TRABAJO)
      references TRABAJOS (ID_TRABAJO)
         on delete restrict on update restrict;

alter table DETALLE
   add constraint FK_DETALLE_FACT_DETA_FACTURA foreign key (ID_FACTURA)
      references FACTURA (ID_FACTURA)
      on delete restrict on update restrict;

alter table DETALLE
   add constraint FK_DETALLE_CT_PRODUCTO foreign key (ID_PRODUCTO)
      references PRODUCTO (ID_PRODUCTO)
      on delete restrict on update restrict;

alter table EGRESOS
   add constraint FK_EGRESOS_CAJA_EGRE_CAJA foreign key (ID_CAJA)
      references CAJA (ID_CAJA)
      on delete restrict on update restrict;

/*alter table FACTURA
   add constraint FK_FACTURA_FACTURA_T_TRABAJOS foreign key (ID_TRABAJO)
      references TRABAJOS (ID_TRABAJO)
      on delete restrict on update restrict;*/

alter table FACTURA
   add constraint FK_FACTURA_FACT_CLIE_CLIENTE foreign key (ID_CLIENTE)
      references CLIENTE (ID_CLIENTE)
      on delete restrict on update restrict;

/*alter table FACTURA
   add constraint FK_FACTURA_FACT_CUEN_CUENTA foreign key (ID_CUENTA)
      references CUENTA (ID_CUENTA)
      on delete restrict on update restrict;*/

/*alter table FACTURA
   add constraint FK_FACTURA_FACT_DETA_DETALLE foreign key (ID_DETALLE)
      references DETALLE (ID_DETALLE)
      on delete restrict on update restrict;*/

alter table FACTURA
   add constraint FK_FACTURA_FACT_USUA_USUARIO foreign key (ID_USUARIO)
      references USUARIO (ID_USUARIO)
      on delete restrict on update restrict;

/*alter table PRODUCTO
   add constraint FK_PRODUCTO_DETALLE_P_DETALLE foreign key (ID_DETALLE)
      references DETALLE (ID_DETALLE)
      on delete restrict on update restrict;*/

/*alter table TRABAJOS
   add constraint FK_TRABAJOS_CUENTA_T_CUENTA foreign key (ID_CUENTA)
      references CUENTA (ID_CUENTA)
      on delete restrict on update restrict;*/

alter table TRABAJOS
   add constraint FK_TRABAJOS_FACTURA_T_FACTURA foreign key (ID_FACTURA)
      references FACTURA (ID_FACTURA)
      on delete restrict on update restrict;

alter table ABONO
   add constraint FK_ABONO_CUENTA foreign key (ID_CUENTA)
      references CUENTA (ID_CUENTA)
      on delete restrict on update restrict;