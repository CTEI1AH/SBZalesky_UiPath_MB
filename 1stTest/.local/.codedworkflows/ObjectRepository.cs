using UiPath.CodedWorkflows.DescriptorIntegration;

namespace _1stTest.ObjectRepository
{
    public static class Descriptors
    {
        public static class __4_Московская_Биржа___Яндекс_Браузер
        {
            static string _reference = "CbblHALADUqX_LwDeTOsDw/WAVCNFaK0ECpZ0MXLQkbYQ";
            public static _Implementation.___4_Московская_Биржа___Яндекс_Браузер.___4_Московская_Биржа___Яндекс_Браузер _4_Московская_Биржа___Яндекс_Браузер { get; private set; } = new _Implementation.___4_Московская_Биржа___Яндекс_Браузер.___4_Московская_Биржа___Яндекс_Браузер();
        }
    }
}

namespace _1stTest._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace ___4_Московская_Биржа___Яндекс_Браузер.__4_Московская_Биржа___Яндекс_Браузер
    {
        public class __Element__text_Значения_с_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Element__text_Значения_с_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "CbblHALADUqX_LwDeTOsDw/ocG51_zr402wCfEks-hlJg", DisplayName = "Element 'text Значения с'", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace ___4_Московская_Биржа___Яндекс_Браузер.__4_Московская_Биржа___Яндекс_Браузер
    {
        public class __Extract_Table_Data : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Extract_Table_Data(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "CbblHALADUqX_LwDeTOsDw/5lU36XP6GEylV1mqdZ5jFA", DisplayName = "Extract Table Data", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace ___4_Московская_Биржа___Яндекс_Браузер.__4_Московская_Биржа___Яндекс_Браузер
    {
        public class __Mouse_Scroll : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Mouse_Scroll(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "CbblHALADUqX_LwDeTOsDw/MtfW-aZol02d8owkgLLMlQ", DisplayName = "Mouse Scroll", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace ___4_Московская_Биржа___Яндекс_Браузер
    {
        public class ___4_Московская_Биржа___Яндекс_Браузер : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public ___4_Московская_Биржа___Яндекс_Браузер()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "CbblHALADUqX_LwDeTOsDw/Y8-bWL1kfkyGvKlKR9lvCw", DisplayName = "4 Московская Биржа — Яндекс Браузер", Screen = this};
                Element__text_Значения_с_ = new _Implementation.___4_Московская_Биржа___Яндекс_Браузер.__4_Московская_Биржа___Яндекс_Браузер.__Element__text_Значения_с_(this, null);
                Extract_Table_Data = new _Implementation.___4_Московская_Биржа___Яндекс_Браузер.__4_Московская_Биржа___Яндекс_Браузер.__Extract_Table_Data(this, null);
                Mouse_Scroll = new _Implementation.___4_Московская_Биржа___Яндекс_Браузер.__4_Московская_Биржа___Яндекс_Браузер.__Mouse_Scroll(this, null);
            }

            public _Implementation.___4_Московская_Биржа___Яндекс_Браузер.__4_Московская_Биржа___Яндекс_Браузер.__Element__text_Значения_с_ Element__text_Значения_с_ { get; private set; }

            public _Implementation.___4_Московская_Биржа___Яндекс_Браузер.__4_Московская_Биржа___Яндекс_Браузер.__Extract_Table_Data Extract_Table_Data { get; private set; }

            public _Implementation.___4_Московская_Биржа___Яндекс_Браузер.__4_Московская_Биржа___Яндекс_Браузер.__Mouse_Scroll Mouse_Scroll { get; private set; }
        }
    }
}