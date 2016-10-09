/* SCRIPT: CRE_DB.sql */
/* Info ICI */

SET NOCOUNT ON

PRINT 'CREATING DATABASE'
DROP DATABASE PE2_Officiel;
GO
CREATE DATABASE PE2_Officiel;
GO

:r CRE_PACK_Evenement.sql
:r CRE_PACK_Forfait.sql
:r CRE_PACK_Personnel.sql
:r CRE_PACK_Publicite.sql
:r CTE_PACK_Evenement.sql
:r CTE_PACK_Forfait.sql
:r CTE_PACK_Personnel.sql
:r CTE_PACK_Publicite.sql
:r INST_PACK_Evenement.sql
:r INST_PACK_Forfait.sql
:r INST_PACK_Personnel.sql
:r INST_PACK_Publicite.sql

SET NOCOUNT OFF

PRINT 'DATABASE CREATE IS COMPLETE'

GO