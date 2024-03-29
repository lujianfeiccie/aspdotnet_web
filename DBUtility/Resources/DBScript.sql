 CREATE TABLE [dbo].[tb_log](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[userName] [nchar](10) NULL,
	[czDate] [datetime] NULL,
	[czwz] [nvarchar](50) NULL,
	[cz] [nvarchar](10) NULL
)  

 
CREATE TABLE [dbo].[tb_role](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[name] [nvarchar](50) NOT NULL,
	[bz] [nvarchar](max) NULL
  )  


CREATE TABLE [dbo].[tb_user](
	[UserID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[UserName] [nvarchar](50) NOT NULL,
	[PassWord] [nvarchar](50) NOT NULL,
	[RoleID] [int] NOT NULL,
	[TrueName] [nvarchar](50) NULL
  ) 

 
CREATE TABLE [dbo].[tb_zdms](
	[zdm] [nvarchar](20) NOT NULL PRIMARY KEY,
	[zdms] [nvarchar](50) NOT NULL
  )  

 
CREATE TABLE [dbo].[tb_desc](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[zdmc] [nchar](10) NOT NULL,
	[zID] [int] NOT NULL,
	[zdz] [nvarchar](50) NOT NULL
 
)  

 
CREATE TABLE [dbo].[tb_lxbx](
    [ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[qrID] [nvarchar](12) NULL,
	[zbID] [nvarchar](18) NULL,
	[xm] [nvarchar](50) NULL,
	[xb] [nvarchar](50) NULL,
	[csn] [nvarchar](15) NULL,
	[mz] [nvarchar](50) NULL,
	[hy] [nvarchar](50) NULL,
	[whcd] [nvarchar](50) NULL,
	[gj] [nvarchar](50) NULL,
	[s] [nvarchar](20) NULL,
	[x] [nvarchar](20) NULL,
	[grtj] [nvarchar](50) NULL,
	[jcs] [nvarchar](50) NULL,
	[zytz] [nvarchar](50) NULL,
	[jcfl] [nvarchar](50) NULL,
	[hjqk] [nvarchar](50) NULL,
	[xz] [nvarchar](50) NULL,
	[yxpd] [nvarchar](15) NULL,
	[toAIDS] [nvarchar](15) NULL,
	[xzqy] [nvarchar](50) NULL,
	[xxdz] [nvarchar](50) NULL,
	[sjdw] [nvarchar](100) NULL,
	[po] [nvarchar](50) NULL,
	[xh] [nvarchar](50) NULL,
	[isDead] [nvarchar](10) NULL,
	[bz] [nvarchar](max) NULL,
	[userName] [nvarchar](50) NULL,
	[inTime] [nvarchar](50) NULL,
	[flag] [int] NULL,
	[showToUser] [int] NULL CONSTRAINT [DF__tb_lxbx__showToU__656C112C]  DEFAULT (1),
  [verifyDate] [nvarchar](50) NULL
) 


CREATE TABLE [dbo].[tb_sfjc](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[zbID] [nvarchar](18) NULL,
	[qrID] [nvarchar](10) NULL,
	[qrDate] [nvarchar](50) NULL,
	[xm] [nvarchar](50) NULL,
	[xb] [nvarchar](10) NULL,
	[csDate] [nvarchar](50) NULL,
	[grtj] [nvarchar](50) NULL,
	[xz] [nvarchar](50) NULL,
	[xzqy] [nvarchar](50) NULL,
	[kbd_zllx] [nvarchar](50) NULL,
	[kbd_jrDate] [nvarchar](50) NULL,
	[kbd_zlID] [nvarchar](13) NULL,
	[kbd_wczk] [nvarchar](50) NULL,
	[sf_scsf] [nvarchar](50) NULL,
	[sf_sfgr] [nvarchar](50) NULL,
	[sf_CD4] [nvarchar](50) NULL,
	[sf_bdzl] [nvarchar](50) NULL,
	[po_ktjc] [nvarchar](50) NULL,
	[po_sfdljc] [nvarchar](50) NULL,
	[znjc] [nvarchar](50) NULL,
	[isDead] [nvarchar](50) NULL,
	[bz] [nvarchar](max) NULL,
	[userName] [nvarchar](50) NULL,
	[inTime] [nvarchar](50) NULL,
	[flag] [int] NULL,
	[showToUser] [int] NULL CONSTRAINT [DF__tb_sfjc__showToU__6754599E]  DEFAULT (1),
  [verifyDate] [nvarchar](50) NULL
) 

 
CREATE TABLE [dbo].[temp_tb_lxbx](
 [ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[qrID] [nvarchar](12) NULL,
	[zbID] [nvarchar](18) NULL,
	[xm] [nvarchar](50) NULL,
	[xb] [nvarchar](50) NULL,
	[csn] [nvarchar](15) NULL,
	[mz] [nvarchar](50) NULL,
	[hy] [nvarchar](50) NULL,
	[whcd] [nvarchar](50) NULL,
	[gj] [nvarchar](50) NULL,
	[s] [nvarchar](20) NULL,
	[x] [nvarchar](20) NULL,
	[grtj] [nvarchar](50) NULL,
	[jcs] [nvarchar](50) NULL,
	[zytz] [nvarchar](50) NULL,
	[jcfl] [nvarchar](50) NULL,
	[hjqk] [nvarchar](50) NULL,
	[xz] [nvarchar](50) NULL,
	[yxpd] [nvarchar](15) NULL,
	[toAIDS] [nvarchar](15) NULL,
	[xzqy] [nvarchar](50) NULL,
	[xxdz] [nvarchar](50) NULL,
	[sjdw] [nvarchar](100) NULL,
	[po] [nvarchar](50) NULL,
	[xh] [nvarchar](50) NULL,
	[isDead] [nvarchar](10) NULL,
	[bz] [nvarchar](max) NULL,
	[userName] [nvarchar](50) NULL,
	[inTime] [nvarchar](50) NULL,
	[flag] [int]  NULL,
	[showToUser] [int] NULL DEFAULT (1),
	 [verifyDate] [nvarchar](50) NULL
 
)  

 
CREATE TABLE [dbo].[temp_tb_sfjc](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[zbID] [nvarchar](18) NULL,
	[qrID] [nvarchar](10) NULL,
	[qrDate] [nvarchar](50) NULL,
	[xm] [nvarchar](50) NULL,
	[xb] [nvarchar](10) NULL,
	[csDate] [nvarchar](50) NULL,
	[grtj] [nvarchar](50) NULL,
	[xz] [nvarchar](50) NULL,
	[xzqy] [nvarchar](50) NULL,
	[kbd_zllx] [nvarchar](50) NULL,
	[kbd_jrDate] [nvarchar](50) NULL,
	[kbd_zlID] [nvarchar](13) NULL,
	[kbd_wczk] [nvarchar](50) NULL,
	[sf_scsf] [nvarchar](50) NULL,
	[sf_sfgr] [nvarchar](50) NULL,
	[sf_CD4] [nvarchar](50) NULL,
	[sf_bdzl] [nvarchar](50) NULL,
	[po_ktjc] [nvarchar](50) NULL,
	[po_sfdljc] [nvarchar](50) NULL,
	[znjc] [nvarchar](50) NULL,
	[isDead] [nvarchar](50) NULL,
	[bz] [nvarchar](max) NULL,
	[userName] [nvarchar](50) NULL,
	[inTime] [nvarchar](50) NULL,
	[flag] [int] NULL,
	[showToUser] [int] NULL DEFAULT (1),
	 [verifyDate] [nvarchar](50) NULL
)  

 
CREATE TABLE [dbo].[tb_yxyb](
 [ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[bcwz] [nvarchar](50) NULL,
	[lsID] [nvarchar](50) NULL,
	[qrID] [nvarchar](10) NULL,
	[qrDate] [nvarchar](50) NULL,
	[zbID] [nvarchar](18) NULL,
	[cyDate] [nvarchar](50) NULL,
	[xm] [nvarchar](50) NULL,
	[xb] [nvarchar](10) NULL,
	[csDate] [nvarchar](50) NULL,
	[grtj] [nvarchar](50) NULL,
	[qx] [nvarchar](50) NULL,
	[xj] [nvarchar](50) NULL,
	[xxb] [nvarchar](50) NULL,
	[PBMC] [nvarchar](50) NULL,
	[fxxb] [nvarchar](50) NULL,
	[qt] [nvarchar](50) NULL,
	[CD4] [nvarchar](50) NULL,
	[bdzl] [nvarchar](50) NULL,
	[HCV] [nvarchar](50) NULL,
	[HBV] [nvarchar](50) NULL,
	[TB] [nvarchar](50) NULL,
	[md] [nvarchar](50) NULL,
	[hb_qt] [nvarchar](50) NULL,
	[userName] [nvarchar](50) NULL,
	[inTime] [nvarchar](50) NULL,
	[flag] [int] NULL,
	[showToUser] [int] NULL CONSTRAINT [DF__tb_yxyb__showToU__66603565]  DEFAULT (1),
	 [verifyDate] [nvarchar](50) NULL
 
)  
 
CREATE TABLE [dbo].[temp_tb_yxyb](
 [ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[bcwz] [nvarchar](50)  NULL,
	[lsID] [nvarchar](50)  NULL,
	[qrID] [nvarchar](10)  NULL,
	[qrDate] [nvarchar](50) NULL,
	[zbID] [nvarchar](18) NULL,
	[cyDate] [nvarchar](50) NULL,
	[xm] [nvarchar](50) NULL,
	[xb] [nvarchar](10) NULL,
	[csDate] [nvarchar](50) NULL,
	[grtj] [nvarchar](50) NULL,
	[qx] [nvarchar](50) NULL,
	[xj] [nvarchar](50) NULL,
	[xxb] [nvarchar](50) NULL,
	[PBMC] [nvarchar](50) NULL,
	[fxxb] [nvarchar](50) NULL,
	[qt] [nvarchar](50) NULL,
	[CD4] [nvarchar](50) NULL,
	[bdzl] [nvarchar](50) NULL,
	[HCV] [nvarchar](50) NULL,
	[HBV] [nvarchar](50) NULL,
	[TB] [nvarchar](50) NULL,
	[md] [nvarchar](50) NULL,
	[hb_qt] [nvarchar](50) NULL,
	[userName] [nvarchar](50) NULL,
	[inTime] [nvarchar](50) NULL,
	[flag] [int] NULL,
	[showToUser] [int] NULL DEFAULT (1),
  [verifyDate] [nvarchar](50) NULL
) 

 
CREATE TABLE [dbo].[tb_comments](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[name] [nvarchar](50) NULL,
	[email] [nvarchar](50)  NULL,
	[qq] [nvarchar](15)  NULL,
	[content] [nvarchar](max)  NULL,
	[addTime] [nvarchar](50)  NULL,
	[reply] [nvarchar](max) NULL,
	[isreply] [bit] NULL
)
 
 
 
