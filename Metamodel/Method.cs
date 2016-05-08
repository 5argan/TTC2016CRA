//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace TTC2016.ArchitectureCRA.ArchitectureCRA
{
    
    
    /// <summary>
    /// The default implementation of the Method class
    /// </summary>
    [XmlNamespaceAttribute("http://momot.big.tuwien.ac.at/architectureCRA/1.0")]
    [XmlNamespacePrefixAttribute("architectureCRA")]
    [ModelRepresentationClassAttribute("http://momot.big.tuwien.ac.at/architectureCRA/1.0#//Method/")]
    [DebuggerDisplayAttribute("Method {Name}")]
    public class Method : Feature, IMethod, IModelElement
    {
        
        /// <summary>
        /// The backing field for the DataDependency property
        /// </summary>
        private ObservableAssociationList<IAttribute> _dataDependency;
        
        /// <summary>
        /// The backing field for the FunctionalDependency property
        /// </summary>
        private ObservableAssociationList<IMethod> _functionalDependency;
        
        public Method()
        {
            this._dataDependency = new ObservableAssociationList<IAttribute>();
            this._dataDependency.CollectionChanged += this.DataDependencyCollectionChanged;
            this._functionalDependency = new ObservableAssociationList<IMethod>();
            this._functionalDependency.CollectionChanged += this.FunctionalDependencyCollectionChanged;
        }
        
        /// <summary>
        /// The dataDependency property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("dataDependency")]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public virtual IListExpression<IAttribute> DataDependency
        {
            get
            {
                return this._dataDependency;
            }
        }
        
        /// <summary>
        /// The functionalDependency property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("functionalDependency")]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public virtual IListExpression<IMethod> FunctionalDependency
        {
            get
            {
                return this._functionalDependency;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new MethodReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://momot.big.tuwien.ac.at/architectureCRA/1.0#//Method/");
            }
        }
        
        /// <summary>
        /// Forwards change notifications for the DataDependency property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void DataDependencyCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("DataDependency", e);
        }
        
        /// <summary>
        /// Forwards change notifications for the FunctionalDependency property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void FunctionalDependencyCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("FunctionalDependency", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "DATADEPENDENCY"))
            {
                return this._dataDependency;
            }
            if ((feature == "FUNCTIONALDEPENDENCY"))
            {
                return this._functionalDependency;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            return ((NMF.Models.Meta.IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://momot.big.tuwien.ac.at/architectureCRA/1.0#//Method/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Method class
        /// </summary>
        public class MethodReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Method _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public MethodReferencedElementsCollection(Method parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    count = (count + this._parent.DataDependency.Count);
                    count = (count + this._parent.FunctionalDependency.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.DataDependency.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.FunctionalDependency.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.DataDependency.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.FunctionalDependency.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IAttribute dataDependencyCasted = item.As<IAttribute>();
                if ((dataDependencyCasted != null))
                {
                    this._parent.DataDependency.Add(dataDependencyCasted);
                }
                IMethod functionalDependencyCasted = item.As<IMethod>();
                if ((functionalDependencyCasted != null))
                {
                    this._parent.FunctionalDependency.Add(functionalDependencyCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.DataDependency.Clear();
                this._parent.FunctionalDependency.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.DataDependency.Contains(item))
                {
                    return true;
                }
                if (this._parent.FunctionalDependency.Contains(item))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> dataDependencyEnumerator = this._parent.DataDependency.GetEnumerator();
                try
                {
                    for (
                    ; dataDependencyEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = dataDependencyEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    dataDependencyEnumerator.Dispose();
                }
                IEnumerator<IModelElement> functionalDependencyEnumerator = this._parent.FunctionalDependency.GetEnumerator();
                try
                {
                    for (
                    ; functionalDependencyEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = functionalDependencyEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    functionalDependencyEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IAttribute attributeItem = item.As<IAttribute>();
                if (((attributeItem != null) 
                            && this._parent.DataDependency.Remove(attributeItem)))
                {
                    return true;
                }
                IMethod methodItem = item.As<IMethod>();
                if (((methodItem != null) 
                            && this._parent.FunctionalDependency.Remove(methodItem)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.DataDependency).Concat(this._parent.FunctionalDependency).GetEnumerator();
            }
        }
    }
}

