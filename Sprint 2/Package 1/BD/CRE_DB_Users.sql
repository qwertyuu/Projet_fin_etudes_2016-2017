/* SCRIPT: CRE_DB.sql */
/* Info ICI */

SET NOCOUNT ON

PRINT 'CREATE USERS'

SET DATEFORMAT ymd
:r CTE_AbpUsers.sql
:r INST_AbpUsers.sql
:r INST_Roles.sql
:r INST_PACK_Personnel.sql

SET NOCOUNT OFF

PRINT 'USERS DONE'

GO