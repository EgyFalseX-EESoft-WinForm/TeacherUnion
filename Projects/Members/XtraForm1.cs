﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Members
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();

            linqServerModeSource1.QueryableSource = new DataSources.Linq.dsTeachersUnionViewsDataContext().vTBLMembersQry05s;
            //linqServerModeSource1.Reload();
        }
    }
}