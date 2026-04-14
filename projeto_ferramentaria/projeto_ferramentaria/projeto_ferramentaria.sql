CREATE DATABASE IF NOT EXISTS ferramentaria;
USE ferramentaria;

CREATE TABLE IF NOT EXISTS categoria_ferramenta(
id_categoria INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
categoria VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS areas_csn(
id_area INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
area VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS cargos(
id_cargo INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
cargo VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS local_ferramentaria(
id_local INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
local TEXT NOT NULL
);

CREATE TABLE IF NOT EXISTS funcionario_ferramentaria(
id_funcionario_f INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
nome_funcionario_f TEXT NOT NULL,
matricula_csn VARCHAR(7) UNIQUE NOT NULL,
data_nascimento DATE NOT NULL,
id_cargo INT NOT NULL,
id_local INT NOT NULL,
id_area INT NOT NULL,
FOREIGN KEY (id_cargo)
REFERENCES cargos (id_cargo),
FOREIGN KEY (id_local)
REFERENCES local_ferramentaria (id_local),
FOREIGN KEY (id_area)
REFERENCES areas_csn (id_area)
);

CREATE TABLE IF NOT EXISTS funcionario(
id_funcionario INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
nome_funcionario TEXT NOT NULL,
matricula_csn VARCHAR(7) UNIQUE NOT NULL,
data_nascimento DATE NOT NULL,
id_cargo INT NOT NULL,
id_area INT NOT NULL,
FOREIGN KEY (id_cargo)
REFERENCES cargos (id_cargo),
FOREIGN KEY (id_area)
REFERENCES areas_csn (id_area)
);

CREATE TABLE IF NOT EXISTS ferramenta(
id_ferramenta INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
nome_ferramenta VARCHAR(100) NOT NULL,
estoque_ferramenta INT NOT NULL,
id_local_f INT NOT NULL,
id_categoria INT NOT NULL,
FOREIGN KEY (id_local_f)
REFERENCES local_ferramentaria (id_local),
FOREIGN KEY (id_categoria)
REFERENCES categoria_ferramenta (id_categoria)
);

CREATE TABLE IF NOT EXISTS emprestimo(
id_emprestimo INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
id_funcionario INT NOT NULL,
id_ferramenta INT NOT NULL,
id_funcionario_f INT NOT NULL,
data_emprestimo DATE NOT NULL,
data_devolucao DATE NOT NULL,
FOREIGN KEY (id_funcionario)
REFERENCES funcionario (id_funcionario),
FOREIGN KEY (id_ferramenta)
REFERENCES ferramenta (id_ferramenta),
FOREIGN KEY(id_funcionario_f)
REFERENCES funcionario_ferramentaria (id_funcionario_f)
);

-- INSERT INTO categoria_ferramenta (categoria) VALUES
-- (),
-- (),
-- ();

-- INSERT INTO areas_csn (area) VALUES
-- (),
-- (),
-- ();

-- INSERT INTO cargos (cargo) VALUES
-- (),
-- (),
-- ();

-- INSERT INTO local_ferramentaria (local) VALUES
-- (),
-- (),
-- ();

-- INSERT INTO funcionario_ferramentaria (nome_funcionario, matricula_csn, data_nascimento, id_cargo, id_local, id_area) VALUES
-- (),
-- (),
-- ();

-- INSERT INTO funcionario (nome_funcionario, matricula_csn, data_nascimento, id_cargo, id_area) VALUES
-- (),
-- (),
-- ();

-- INSERT INTO ferramenta (nome_ferramenta, estoque_ferramenta, id_local_f, id_categoria) VALUES
-- (),
-- (),
-- ();

-- INSERT INTO emprestimo (id_funcionario, id_ferramenta, id_funcionario_f, data_emprestimo, data_devolucao) VALUES
-- (),
-- (),
-- ();

SELECT cf.id_categoria AS "Id categoria", cf.categoria AS "Categorias" FROM categoria_ferramenta cf;

SELECT ac.id_area AS "Id area", ac.area "Areas da Csn" FROM areas_csn ac;

SELECT c.id_cargo "Id cargo", c.cargo "Cargos" FROM cargos c;

SELECT lc.id_local AS "Id local", lc.local AS "Local da ferramentaria" FROM local_ferramentaria lc;

SELECT ff.id_funcionario_f AS "Id funcionario da ferramentaria", ff.nome_funcionario_f AS "Nome", ff.matricula_csn AS "Matricula csn", ff.data_nascimento AS "Data de nascimento", c.cargo AS "cargo atual", lf.local AS "endereço da ferramentaria", ac.area AS "local de trabalho" FROM funcionario_ferramentaria ff 
LEFT JOIN cargos c ON c.id_cargo = ff.id_cargo
LEFT JOIN local_ferramentaria lf ON lf.id_local = ff.id_local
LEFT JOIN areas_csn ac ON ac.id_area = ff.id_area
;

SELECT f.id_funcionario AS "Id funcionario", f.nome_funcionario AS "Nome do funcionario", f.matricula_csn AS "Matricula csn", f.data_nascimento AS "Data de nascimento", c.cargo AS "Cargo atual", ac.area AS "Local de trabalho" FROM funcionario f
LEFT JOIN cargos c ON c.id_cargo = f.id_cargo 
LEFT JOIN areas_csn ac ON ac.id_area = f.id_area
;

SELECT fe.id_ferramenta AS "Id ferramenta", fe.nome_ferramenta AS "Nome", fe.estoque_ferramenta AS "Estoque total", lf.local AS "Local da ferramentaria", cf.categoria AS "Categoria da ferramenta" FROM ferramenta fe
LEFT JOIN local_ferramentaria lf ON lf.id_local = fe.id_local_f
LEFT JOIN categoria_ferramenta cf ON cf.id_categoria = fe.id_categoria
;

SELECT e.id_emprestimo AS "Id emprestimo", f.nome_funcionario "Nome funcionario", f.matricula_csn AS "Matricula csn", c.cargo AS "Cargo do funcionario", fe.nome_ferramenta AS "Nome da ferramenta", ff.nome_funcionario_f AS "Nome do funcionario da ferramentaria", ff.matricula_csn, c2.cargo AS "Cargo ferramentaria", e.data_emprestimo AS "Data emprestimo", e.data_devolucao AS "Data devolução" FROM emprestimo e
LEFT JOIN funcionario f ON f.id_funcionario = e.id_funcionario
LEFT JOIN ferramenta fe ON fe.id_ferramenta = e.id_ferramenta
LEFT JOIN funcionario_ferramentaria ff ON ff.id_funcionario_f = e.id_funcionario_f
LEFT JOIN local_ferramentaria lf ON lf.id_local = ff.id_local 
LEFT JOIN areas_csn ac ON ac.id_area = ff.id_area
INNER JOIN cargos c ON c.id_cargo = f.id_cargo
INNER JOIN cargos c2 ON c2.id_cargo = ff.id_cargo
;

