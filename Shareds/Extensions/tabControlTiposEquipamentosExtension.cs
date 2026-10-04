//using LocacaoEquipamentos.Enums;

//namespace LocacaoEquipamentos.Shareds.Extensions
//{
//    public static class tabControlTiposEquipamentosExtension
//    {
//        public static void ShowTab(TipoEquipamentoEnum tipoEquipamento)
//        {
//            tabPageTipoFerramenta.Parent = null;
//            tabPageTipoInformatica.Parent = null;
//            tabPageTipoMaquinaPesada.Parent = null;

//            switch ((TipoEquipamentoEnum)CbTipoEquipamento.SelectedItem)
//            {
//                case TipoEquipamentoEnum.Ferramenta:
//                    tabPageTipoFerramenta.Parent = tabControlTiposEquipamentos;
//                    break;
//                case TipoEquipamentoEnum.Informatica:
//                    tabPageTipoInformatica.Parent = tabControlTiposEquipamentos;
//                    break;
//                case TipoEquipamentoEnum.MaquinaPesada:
//                    tabPageTipoMaquinaPesada.Parent = tabControlTiposEquipamentos;
//                    break;
//            }
//        }
//    }
//}
