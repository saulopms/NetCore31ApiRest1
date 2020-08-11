-- View: public.vw_voto_listagem

-- DROP VIEW public.vw_voto_listagem;

CREATE OR REPLACE VIEW public.vw_voto_listagem
 AS
 SELECT v.idvoto,
    v.dt_voto,
    to_char(v.hr_voto::interval, 'HH24:MI'::text) AS hr_voto,
    f.funcionario,
    r.recurso,
    v.comentario
   FROM tb_voto v
     JOIN tb_recurso r ON v.idrecurso = r.idrecurso
     JOIN tb_funcionario f ON v.idfuncionario = f.idfuncionario
  ORDER BY v.dt_voto, v.hr_voto, f.funcionario, r.recurso;

ALTER TABLE public.vw_voto_listagem
    OWNER TO postgres;

