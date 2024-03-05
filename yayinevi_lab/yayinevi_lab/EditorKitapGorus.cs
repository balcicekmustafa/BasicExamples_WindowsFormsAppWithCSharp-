using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yayinevi_lab
{   
    public enum editorIncelemeEnum { REDDEDILDI,DUZENLENECEK,ONAYLANDI }
    public class EditorKitapGorus
    {
        private Editor editor;
        private string aciklama;
        private editorIncelemeEnum karar;
        public EditorKitapGorus(Editor editor, string aciklama, editorIncelemeEnum karar)
        {
            this.editor = editor;
            this.aciklama = aciklama;
            this.karar = karar;
        }
        public Editor Editor { get { return editor; } }
        public string Aciklama { get {  return aciklama; } }
        public editorIncelemeEnum Karar { get {  return karar; } }

    }
}
