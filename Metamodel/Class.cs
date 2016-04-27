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
    /// The default implementation of the Class class
    /// </summary>
    [XmlNamespaceAttribute("http://momot.big.tuwien.ac.at/architectureCRA/1.0")]
    [XmlNamespacePrefixAttribute("architectureCRA")]
    [ModelRepresentationClassAttribute("http://momot.big.tuwien.ac.at/architectureCRA/1.0#//Class/")]
    [DebuggerDisplayAttribute("Class {Name}")]
    public class Class : NamedElement, IClass, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Encapsulates property
        /// </summary>
        private ClassEncapsulatesCollection _encapsulates;
        
        public Class()
        {
            this._encapsulates = new ClassEncapsulatesCollection(this);
            this._encapsulates.CollectionChanged += this.EncapsulatesCollectionChanged;
        }
        
        /// <summary>
        /// The encapsulates property
        /// </summary>
        [LowerBoundAttribute(1)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("encapsulates")]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("isEncapsulatedBy")]
        [ConstantAttribute()]
        public virtual IListExpression<IFeature> Encapsulates
        {
            get
            {
                return this._encapsulates;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ClassReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://momot.big.tuwien.ac.at/architectureCRA/1.0#//Class/");
            }
        }
        
        /// <summary>
        /// Forwards change notifications for the Encapsulates property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EncapsulatesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Encapsulates", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "ENCAPSULATES"))
            {
                return this._encapsulates;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            return ((NMF.Models.Meta.IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://momot.big.tuwien.ac.at/architectureCRA/1.0#//Class/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Class class
        /// </summary>
        public class ClassReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Class _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ClassReferencedElementsCollection(Class parent)
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
                    count = (count + this._parent.Encapsulates.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Encapsulates.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Encapsulates.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IFeature encapsulatesCasted = item.As<IFeature>();
                if ((encapsulatesCasted != null))
                {
                    this._parent.Encapsulates.Add(encapsulatesCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Encapsulates.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Encapsulates.Contains(item))
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
                IEnumerator<IModelElement> encapsulatesEnumerator = this._parent.Encapsulates.GetEnumerator();
                try
                {
                    for (
                    ; encapsulatesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = encapsulatesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    encapsulatesEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IFeature featureItem = item.As<IFeature>();
                if (((featureItem != null) 
                            && this._parent.Encapsulates.Remove(featureItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Encapsulates).GetEnumerator();
            }
        }
    }
}

