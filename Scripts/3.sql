-- Table: public.tb_recurso

-- DROP TABLE public.tb_recurso;

CREATE TABLE public.tb_recurso
(
    idrecurso integer NOT NULL DEFAULT nextval('tb_recurso_idrecurso_seq'::regclass),
    recurso character varying(100) COLLATE pg_catalog."default",
    detalhes text COLLATE pg_catalog."default",
    CONSTRAINT tb_recurso_pkey PRIMARY KEY (idrecurso)
)

TABLESPACE pg_default;

ALTER TABLE public.tb_recurso
    OWNER to postgres;
-- Index: uk_recurso

-- DROP INDEX public.uk_recurso;

CREATE UNIQUE INDEX uk_recurso
    ON public.tb_recurso USING btree
    (recurso COLLATE pg_catalog."default" ASC NULLS LAST)
    TABLESPACE pg_default;