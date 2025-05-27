-- Criação da tabela Clientes
CREATE TABLE Clientes (
    cliente_id SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    telefone VARCHAR(15),
    senha VARCHAR(100) NOT NULL
);

-- Criação da tabela Filmes
CREATE TABLE Filmes (
    filme_id SERIAL PRIMARY KEY,
    titulo VARCHAR(100) NOT NULL,
    descricao TEXT,
    duracao INT,
    classificacao VARCHAR(10),
    genero VARCHAR(50)
);

-- Criação da tabela Horarios
CREATE TABLE Horarios (
    horario_id SERIAL PRIMARY KEY,
    filme_id INT REFERENCES Filmes(filme_id),
    data DATE NOT NULL,
    hora TIME NOT NULL,
    sala VARCHAR(10)
);

-- Criação da tabela Assentos
CREATE TABLE Assentos (
    assento_id SERIAL PRIMARY KEY,
    horario_id INT REFERENCES Horarios(horario_id),
    numero_assento VARCHAR(5) NOT NULL,
    disponivel BOOLEAN DEFAULT TRUE
);

-- Criação da tabela Reservas
CREATE TABLE Reservas (
    reserva_id SERIAL PRIMARY KEY,
    cliente_id INT REFERENCES Clientes(cliente_id),
    horario_id INT REFERENCES Horarios(horario_id),
    assento_id INT REFERENCES Assentos(assento_id),
    data_reserva TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Criação da tabela Pagamentos
CREATE TABLE Pagamentos (
    pagamento_id SERIAL PRIMARY KEY,
    reserva_id INT REFERENCES Reservas(reserva_id),
    valor DECIMAL(10, 2) NOT NULL,
    metodo_pagamento VARCHAR(50),
    data_pagamento TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);