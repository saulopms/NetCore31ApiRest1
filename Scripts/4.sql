-- Table: public.tb_voto

-- DROP TABLE public.tb_voto;

CREATE TABLE public.tb_voto
(
    idvoto integer NOT NULL DEFAULT nextval('tb_voto_idvoto_seq'::regclass),
    dt_voto date NOT NULL,
    hr_voto time without time zone NOT NULL,
    idrecurso integer NOT NULL,
    idfuncionario integer NOT NULL,
    comentario character varying(255) COLLATE pg_catalog."default",
    CONSTRAINT tb_voto_pkey PRIMARY KEY (idvoto),
    CONSTRAINT fk_voto_funcionario FOREIGN KEY (idfuncionario)
        REFERENCES public.tb_funcionario (idfuncionario) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID,
    CONSTRAINT fk_voto_recurso FOREIGN KEY (idrecurso)
        REFERENCES public.tb_recurso (idrecurso) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)

TABLESPACE pg_default;

ALTER TABLE public.tb_voto
    OWNER to postgres;
-- Index: idx_recurso

-- DROP INDEX public.idx_recurso;

CREATE INDEX idx_recurso
    ON public.tb_voto USING btree
    (idrecurso ASC NULLS LAST)
    TABLESPACE pg_default;