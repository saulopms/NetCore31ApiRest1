-- View: public.vw_voto

-- DROP VIEW public.vw_voto;

CREATE OR REPLACE VIEW public.vw_voto
 AS
 SELECT r.recurso,
    count(v.idrecurso) AS votos,
    count(v.idrecurso)::double precision / (( SELECT count(*) AS count
           FROM tb_voto))::double precision * 100::double precision AS percentual
   FROM tb_voto v
     JOIN tb_recurso r ON v.idrecurso = r.idrecurso
  GROUP BY r.recurso
  ORDER BY (count(v.idrecurso)) DESC;

ALTER TABLE public.vw_voto
    OWNER TO postgres;

