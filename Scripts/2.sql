-- Table: public.tb_funcionario

-- DROP TABLE public.tb_funcionario;

CREATE TABLE public.tb_funcionario
(
    idfuncionario integer NOT NULL DEFAULT nextval('tb_funcionario_idfuncionario_seq'::regclass),
    funcionario character varying(50) COLLATE pg_catalog."default" NOT NULL,
    email character varying(100) COLLATE pg_catalog."default" NOT NULL,
    senha character varying(255) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT tb_funcionario_pkey PRIMARY KEY (idfuncionario)
)

TABLESPACE pg_default;

ALTER TABLE public.tb_funcionario
    OWNER to postgres;
-- Index: idx_tb_funcionario_nome

-- DROP INDEX public.idx_tb_funcionario_nome;

CREATE INDEX idx_tb_funcionario_nome
    ON public.tb_funcionario USING btree
    (funcionario COLLATE pg_catalog."default" ASC NULLS LAST)
    TABLESPACE pg_default;
-- Index: uk_tb_funcionario_email

-- DROP INDEX public.uk_tb_funcionario_email;

CREATE UNIQUE INDEX uk_tb_funcionario_email
    ON public.tb_funcionario USING btree
    (email COLLATE pg_catalog."default" ASC NULLS LAST)
    TABLESPACE pg_default;