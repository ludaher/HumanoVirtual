using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.HAVIR.Scripts.Game.Main.GraphModel
{

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://graphml.graphdrawing.org/xmlns")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://graphml.graphdrawing.org/xmlns", IsNullable = false)]
    public partial class graphml
    {

        private graphmlKey[] keyField;

        private graphmlGraph graphField;

        private graphmlData dataField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("key")]
        public graphmlKey[] key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <comentarios/>
        public graphmlGraph graph
        {
            get
            {
                return this.graphField;
            }
            set
            {
                this.graphField = value;
            }
        }

        /// <comentarios/>
        public graphmlData data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://graphml.graphdrawing.org/xmlns")]
    public partial class graphmlKey
    {

        private string attrnameField;

        private string attrtypeField;

        private string forField;

        private string idField;

        private string yfilestypeField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute("attr.name")]
        public string attrname
        {
            get
            {
                return this.attrnameField;
            }
            set
            {
                this.attrnameField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute("attr.type")]
        public string attrtype
        {
            get
            {
                return this.attrtypeField;
            }
            set
            {
                this.attrtypeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @for
        {
            get
            {
                return this.forField;
            }
            set
            {
                this.forField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute("yfiles.type")]
        public string yfilestype
        {
            get
            {
                return this.yfilestypeField;
            }
            set
            {
                this.yfilestypeField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://graphml.graphdrawing.org/xmlns")]
    public partial class graphmlGraph
    {

        private graphmlGraphData dataField;

        private graphmlGraphNode[] nodeField;

        private graphmlGraphEdge[] edgeField;

        private string edgedefaultField;

        private string idField;

        /// <comentarios/>
        public graphmlGraphData data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("node")]
        public graphmlGraphNode[] node
        {
            get
            {
                return this.nodeField;
            }
            set
            {
                this.nodeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("edge")]
        public graphmlGraphEdge[] edge
        {
            get
            {
                return this.edgeField;
            }
            set
            {
                this.edgeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string edgedefault
        {
            get
            {
                return this.edgedefaultField;
            }
            set
            {
                this.edgedefaultField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://graphml.graphdrawing.org/xmlns")]
    public partial class graphmlGraphData
    {

        private string keyField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://graphml.graphdrawing.org/xmlns")]
    public partial class graphmlGraphNode
    {

        private graphmlGraphNodeData[] dataField;

        private string idField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("data")]
        public graphmlGraphNodeData[] data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://graphml.graphdrawing.org/xmlns")]
    public partial class graphmlGraphNodeData
    {

        private ShapeNode shapeNodeField;

        private string keyField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.yworks.com/xml/graphml")]
        public ShapeNode ShapeNode
        {
            get
            {
                return this.shapeNodeField;
            }
            set
            {
                this.shapeNodeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.yworks.com/xml/graphml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.yworks.com/xml/graphml", IsNullable = false)]
    public partial class ShapeNode
    {

        private ShapeNodeGeometry geometryField;

        private ShapeNodeFill fillField;

        private ShapeNodeBorderStyle borderStyleField;

        private ShapeNodeNodeLabel nodeLabelField;

        private ShapeNodeShape shapeField;

        /// <comentarios/>
        public ShapeNodeGeometry Geometry
        {
            get
            {
                return this.geometryField;
            }
            set
            {
                this.geometryField = value;
            }
        }

        /// <comentarios/>
        public ShapeNodeFill Fill
        {
            get
            {
                return this.fillField;
            }
            set
            {
                this.fillField = value;
            }
        }

        /// <comentarios/>
        public ShapeNodeBorderStyle BorderStyle
        {
            get
            {
                return this.borderStyleField;
            }
            set
            {
                this.borderStyleField = value;
            }
        }

        /// <comentarios/>
        public ShapeNodeNodeLabel NodeLabel
        {
            get
            {
                return this.nodeLabelField;
            }
            set
            {
                this.nodeLabelField = value;
            }
        }

        /// <comentarios/>
        public ShapeNodeShape Shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.yworks.com/xml/graphml")]
    public partial class ShapeNodeGeometry
    {

        private decimal heightField;

        private decimal widthField;

        private decimal xField;

        private decimal yField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.yworks.com/xml/graphml")]
    public partial class ShapeNodeFill
    {

        private string colorField;

        private bool transparentField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool transparent
        {
            get
            {
                return this.transparentField;
            }
            set
            {
                this.transparentField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.yworks.com/xml/graphml")]
    public partial class ShapeNodeBorderStyle
    {

        private string colorField;

        private bool raisedField;

        private string typeField;

        private decimal widthField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool raised
        {
            get
            {
                return this.raisedField;
            }
            set
            {
                this.raisedField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.yworks.com/xml/graphml")]
    public partial class ShapeNodeNodeLabel
    {

        private ShapeNodeNodeLabelLabelModel labelModelField;

        private ShapeNodeNodeLabelModelParameter modelParameterField;

        private string alignmentField;

        private string autoSizePolicyField;

        private string fontFamilyField;

        private byte fontSizeField;

        private string fontStyleField;

        private bool hasBackgroundColorField;

        private bool hasLineColorField;

        private bool hasTextField;

        private decimal heightField;

        private string horizontalTextPositionField;

        private byte iconTextGapField;

        private string modelNameField;

        private string textColorField;

        private string verticalTextPositionField;

        private bool visibleField;

        private decimal widthField;

        private decimal xField;

        private decimal yField;

        /// <comentarios/>
        public ShapeNodeNodeLabelLabelModel LabelModel
        {
            get
            {
                return this.labelModelField;
            }
            set
            {
                this.labelModelField = value;
            }
        }

        /// <comentarios/>
        public ShapeNodeNodeLabelModelParameter ModelParameter
        {
            get
            {
                return this.modelParameterField;
            }
            set
            {
                this.modelParameterField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string alignment
        {
            get
            {
                return this.alignmentField;
            }
            set
            {
                this.alignmentField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string autoSizePolicy
        {
            get
            {
                return this.autoSizePolicyField;
            }
            set
            {
                this.autoSizePolicyField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fontFamily
        {
            get
            {
                return this.fontFamilyField;
            }
            set
            {
                this.fontFamilyField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fontSize
        {
            get
            {
                return this.fontSizeField;
            }
            set
            {
                this.fontSizeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fontStyle
        {
            get
            {
                return this.fontStyleField;
            }
            set
            {
                this.fontStyleField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hasBackgroundColor
        {
            get
            {
                return this.hasBackgroundColorField;
            }
            set
            {
                this.hasBackgroundColorField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hasLineColor
        {
            get
            {
                return this.hasLineColorField;
            }
            set
            {
                this.hasLineColorField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hasText
        {
            get
            {
                return this.hasTextField;
            }
            set
            {
                this.hasTextField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string horizontalTextPosition
        {
            get
            {
                return this.horizontalTextPositionField;
            }
            set
            {
                this.horizontalTextPositionField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte iconTextGap
        {
            get
            {
                return this.iconTextGapField;
            }
            set
            {
                this.iconTextGapField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string modelName
        {
            get
            {
                return this.modelNameField;
            }
            set
            {
                this.modelNameField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string textColor
        {
            get
            {
                return this.textColorField;
            }
            set
            {
                this.textColorField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string verticalTextPosition
        {
            get
            {
                return this.verticalTextPositionField;
            }
            set
            {
                this.verticalTextPositionField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.yworks.com/xml/graphml")]
    public partial class ShapeNodeNodeLabelLabelModel
    {

        private ShapeNodeNodeLabelLabelModelSmartNodeLabelModel smartNodeLabelModelField;

        /// <comentarios/>
        public ShapeNodeNodeLabelLabelModelSmartNodeLabelModel SmartNodeLabelModel
        {
            get
            {
                return this.smartNodeLabelModelField;
            }
            set
            {
                this.smartNodeLabelModelField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.yworks.com/xml/graphml")]
    public partial class ShapeNodeNodeLabelLabelModelSmartNodeLabelModel
    {

        private decimal distanceField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal distance
        {
            get
            {
                return this.distanceField;
            }
            set
            {
                this.distanceField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.yworks.com/xml/graphml")]
    public partial class ShapeNodeNodeLabelModelParameter
    {

        private ShapeNodeNodeLabelModelParameterSmartNodeLabelModelParameter smartNodeLabelModelParameterField;

        /// <comentarios/>
        public ShapeNodeNodeLabelModelParameterSmartNodeLabelModelParameter SmartNodeLabelModelParameter
        {
            get
            {
                return this.smartNodeLabelModelParameterField;
            }
            set
            {
                this.smartNodeLabelModelParameterField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.yworks.com/xml/graphml")]
    public partial class ShapeNodeNodeLabelModelParameterSmartNodeLabelModelParameter
    {

        private decimal labelRatioXField;

        private decimal labelRatioYField;

        private decimal nodeRatioXField;

        private decimal nodeRatioYField;

        private decimal offsetXField;

        private decimal offsetYField;

        private decimal upXField;

        private decimal upYField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal labelRatioX
        {
            get
            {
                return this.labelRatioXField;
            }
            set
            {
                this.labelRatioXField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal labelRatioY
        {
            get
            {
                return this.labelRatioYField;
            }
            set
            {
                this.labelRatioYField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal nodeRatioX
        {
            get
            {
                return this.nodeRatioXField;
            }
            set
            {
                this.nodeRatioXField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal nodeRatioY
        {
            get
            {
                return this.nodeRatioYField;
            }
            set
            {
                this.nodeRatioYField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal offsetX
        {
            get
            {
                return this.offsetXField;
            }
            set
            {
                this.offsetXField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal offsetY
        {
            get
            {
                return this.offsetYField;
            }
            set
            {
                this.offsetYField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal upX
        {
            get
            {
                return this.upXField;
            }
            set
            {
                this.upXField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal upY
        {
            get
            {
                return this.upYField;
            }
            set
            {
                this.upYField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.yworks.com/xml/graphml")]
    public partial class ShapeNodeShape
    {

        private string typeField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://graphml.graphdrawing.org/xmlns")]
    public partial class graphmlGraphEdge
    {

        private graphmlGraphEdgeData[] dataField;

        private string idField;

        private string sourceField;

        private string targetField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("data")]
        public graphmlGraphEdgeData[] data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://graphml.graphdrawing.org/xmlns")]
    public partial class graphmlGraphEdgeData
    {

        private PolyLineEdge polyLineEdgeField;

        private string keyField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.yworks.com/xml/graphml")]
        public PolyLineEdge PolyLineEdge
        {
            get
            {
                return this.polyLineEdgeField;
            }
            set
            {
                this.polyLineEdgeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.yworks.com/xml/graphml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.yworks.com/xml/graphml", IsNullable = false)]
    public partial class PolyLineEdge
    {

        private PolyLineEdgePath pathField;

        private PolyLineEdgeLineStyle lineStyleField;

        private PolyLineEdgeArrows arrowsField;

        private PolyLineEdgeBendStyle bendStyleField;

        /// <comentarios/>
        public PolyLineEdgePath Path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <comentarios/>
        public PolyLineEdgeLineStyle LineStyle
        {
            get
            {
                return this.lineStyleField;
            }
            set
            {
                this.lineStyleField = value;
            }
        }

        /// <comentarios/>
        public PolyLineEdgeArrows Arrows
        {
            get
            {
                return this.arrowsField;
            }
            set
            {
                this.arrowsField = value;
            }
        }

        /// <comentarios/>
        public PolyLineEdgeBendStyle BendStyle
        {
            get
            {
                return this.bendStyleField;
            }
            set
            {
                this.bendStyleField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.yworks.com/xml/graphml")]
    public partial class PolyLineEdgePath
    {

        private decimal sxField;

        private decimal syField;

        private decimal txField;

        private decimal tyField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal sx
        {
            get
            {
                return this.sxField;
            }
            set
            {
                this.sxField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal sy
        {
            get
            {
                return this.syField;
            }
            set
            {
                this.syField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal tx
        {
            get
            {
                return this.txField;
            }
            set
            {
                this.txField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ty
        {
            get
            {
                return this.tyField;
            }
            set
            {
                this.tyField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.yworks.com/xml/graphml")]
    public partial class PolyLineEdgeLineStyle
    {

        private string colorField;

        private string typeField;

        private decimal widthField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.yworks.com/xml/graphml")]
    public partial class PolyLineEdgeArrows
    {

        private string sourceField;

        private string targetField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.yworks.com/xml/graphml")]
    public partial class PolyLineEdgeBendStyle
    {

        private bool smoothedField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool smoothed
        {
            get
            {
                return this.smoothedField;
            }
            set
            {
                this.smoothedField = value;
            }
        }
    }

    /// <comentarios/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://graphml.graphdrawing.org/xmlns")]
    public partial class graphmlData
    {

        private object resourcesField;

        private string keyField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.yworks.com/xml/graphml")]
        public object Resources
        {
            get
            {
                return this.resourcesField;
            }
            set
            {
                this.resourcesField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
    }
}
