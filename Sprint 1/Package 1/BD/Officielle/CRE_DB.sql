/* SCRIPT: CRE_DB.sql */
/* Info ICI */


PRINT 'CREATING DATABASE'
:r CRE_Pack_Contrat.sql
:r CTE_Pack_Contrat.sql
:r INST_Pack_Contrat.sql
:r VUE_Pack_Contrat_20160906.sql

PRINT 'DATABASE CREATE IS COMPLETE'
GO