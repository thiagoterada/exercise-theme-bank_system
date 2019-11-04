CREATE DATABASE BD_AGENCIA;
USE BD_AGENCIA;

CREATE TABLE UF(idUF int primary key auto_increment,
				abrUF char(2) not null,
                nomeUF varchar(100)
);

CREATE TABLE CIDADE(idCid int primary key auto_increment,
					nmCid varchar(100) not null,
                    idUF int not null,
                    CONSTRAINT fk_idUF_CIDADE FOREIGN KEY (idUF) REFERENCES UF(idUF)
);

CREATE TABLE AGENCIA(idAge int primary key auto_increment,
					 nmAge varchar(100),
					 idCidAge int not null,
                     cepAge varchar(9) not null,
                     bairroAge varchar(100) not null,
                     logradouro varchar(100) not null,
                     nroAge int,
                     complAge varchar(100)
);                     

CREATE TABLE CLIENTE(idCli int primary key auto_increment,
					 nmCli varchar(100) not null,
                     cpfCli varchar(14) not null,
                     rgCli varchar(12) not null,
                     sexoCli char(1) not null,
                     dtNascCli datetime not null,
                     idCid int not null,
                     dsEndCli varchar(500) not null,
                     CONSTRAINT fk_idCid_CLIENTE FOREIGN KEY (idCid) REFERENCES CIDADE(idCid)
);

CREATE TABLE TIPO_CONTA(idTipoConta int primary key auto_increment,
						nmTipoConta varchar(40) not null
);

INSERT INTO TIPO_CONTA (nmTipoConta) 
VALUES('Conta Poupança'), ('Conta Corrente'), ('Conta Investimento');

CREATE TABLE CONTA(idConta int primary key auto_increment,
				   idTipoConta int not null,
				   idCli int not null,
                   idAge int not null,
                   dtAberturaConta datetime not null,
                   dtEncerramento datetime,
                   CONSTRAINT fk_idCli_CONTA FOREIGN KEY (idCli) REFERENCES CLIENTE(idCli),
                   CONSTRAINT fk_idTipoConta_CONTA FOREIGN KEY (idTipoConta) REFERENCES TIPO_CONTA(idTipoConta),
                   CONSTRAINT fk_idAge_CONTA FOREIGN KEY (idAge) REFERENCES AGENCIA(idAge)
);

CREATE TABLE CARGO_FUNC(idCargo int primary key auto_increment,
						nmCargo varchar(100) not null
);

INSERT INTO CARGO_FUNC (nmCargo) 
VALUES('Gerente Titular'), ('Gerente Administrativo'), ('Caixa');

CREATE TABLE FUNCIONARIO(idFunc int primary key auto_increment,
					 nmFunc varchar(100) not null,
                     cpfFunc varchar(14) not null,
                     rgFunc varchar(12) not null,
                     sexoFunc char(1) not null,
                     dtNascFunc datetime not null,
                     idCid int not null,
                     dsEndFunc varchar(500) not null,
                     idAge int not null,
                     idCargo int not null,
                     CONSTRAINT fk_idCargo_FUNCIONARIO FOREIGN KEY (idCargo) REFERENCES CARGO_FUNC(idCargo),
                     CONSTRAINT fk_idCid_FUNCIONARIO FOREIGN KEY (idCid) REFERENCES CIDADE(idCid),
                     CONSTRAINT fk_idAge_FUNCIONARIO FOREIGN KEY (idAge) REFERENCES AGENCIA(idAge)
);

/*INSERT UF*/

INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('AC', 'Acre');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('AL', 'Alagoas');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('AP', 'Amapá');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('AM', 'Amazonas');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('BA', 'Bahia');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('CE', 'Ceará');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('DF', 'Distrito Federal');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('ES', 'Espírito Santo');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('GO', 'Goiás');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('MA', 'Maranhão');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('MT', 'Mato Grosso');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('MS', 'Mato Grosso do Sul');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('MG', 'Minas Gerais');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('PA', 'Pará');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('PB', 'Paraíba');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('PR', 'Paraná');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('PE', 'Pernambuco');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('PI', 'Piauí');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('RJ', 'Rio de Janeiro');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('RN', 'Rio Grande do Norte');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('RS', 'Rio Grande do Sul');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('RO', 'Rondônia');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('RR', 'Roraima');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('SC', 'Santa Catarina');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('SP', 'São Paulo');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('SE', 'Sergipe');
INSERT INTO `bd_agencia`.`UF` (`abrUF`, `nomeUF`) VALUES ('TO', 'Tocantins');

/*INSERT CIDADE*/
/*AC*/
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Acrelandia', '1');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Assis Brasil', '1');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Brasileia', '1');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Bujari', '1');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Capixaba', '1');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Cruzeiro do Sul', '1');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Epitaciolandia', '1');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Feijo', '1');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Jordão', '1');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Mancio Lima', '1');
/*AL*/
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Água Branca', '2');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Anadia', '2');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Arapiraca', '2');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Atalaia', '2');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Barra de Santo Antonio', '2');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Barra de São Miguel', '2');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Batalha', '2');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Belo Monte', '2');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Boca da Mata', '2');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Branquinha', '2');
/*AP*/
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Amapa', '3');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Calcoense', '3');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Cutias', '3');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Ferreira Gomes', '3');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Itaubal', '3');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Laranjal do Jari', '3');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Macapá', '3');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Mazagao', '3');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Oiapoque', '3');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Pedra Branca do Amapari', '3');
/*AM*/
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Alvares', '4');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Amatura', '4');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Anama', '4');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Anori', '4');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Apui', '4');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Atalaia do Norte', '4');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Autazes', '4');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Barcelos', '4');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Barreirinha', '4');
INSERT INTO `bd_agencia`.`CIDADE` (`nmCid`, `idUF`) VALUES ('Benjamin Constant', '4');


/*INSERT CLIENTE*/
INSERT INTO `bd_agencia`.`CLIENTE` (`nmCli`, `cpfCli`, `rgCli`, `sexoCli`, `dtNascCli`, `idCid`, `dsEndCli`) VALUES ('Aline', '48350153806', '42789876X', 'M', '2001-07-01', '1', 'Acre');
INSERT INTO `bd_agencia`.`CLIENTE` (`nmCli`, `cpfCli`, `rgCli`, `sexoCli`, `dtNascCli`, `idCid`, `dsEndCli`) VALUES ('Lucas', '48350153806', '42789876X', 'M', '2001-07-01', '2', 'Acre');
INSERT INTO `bd_agencia`.`CLIENTE` (`nmCli`, `cpfCli`, `rgCli`, `sexoCli`, `dtNascCli`, `idCid`, `dsEndCli`) VALUES ('Wallace', '48350153806', '42789876X', 'M', '2001-07-01', '3', 'Acre');
INSERT INTO `bd_agencia`.`CLIENTE` (`nmCli`, `cpfCli`, `rgCli`, `sexoCli`, `dtNascCli`, `idCid`, `dsEndCli`) VALUES ('Isabelle', '48350153806', '42789876X', 'M', '2001-07-01', '4', 'Acre');

/*INSERT AGÊNCIA*/
INSERT INTO `bd_agencia`.`AGENCIA` (`nmAge`, `idCidAge`, `cepAge`, `bairroAge`, `logradouro`, `nroAge`, `complAge`) VALUES ('Agência Taboão', '1', '06756050', 'Pq Monte Alegre', 'Rua Azul', '1', 'sddfis');

SELECT * FROM UF;
SELECT * FROM CIDADE;
SELECT * FROM CLIENTE;
SELECT * FROM TIPO_CONTA;
SELECT * FROM AGENCIA;


