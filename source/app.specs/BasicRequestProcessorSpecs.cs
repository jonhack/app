using Machine.Specifications;
using app.web.core;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
    [Subject(typeof(BasicRequestProcessor))]
    public class BasicRequestProcessorSpecs
    {
        public abstract class concern : Observes<IProcessOneRequest,
                                            BasicRequestProcessor>
        {
        }

        public class when_processing_a_command : concern
        {
            Establish c = () =>
            {
                request = fake.an<IContainRequestInformation>();
            };

            Because b = () =>
                result = sut.can_handle(request);

            It should_handle_a_request = () =>
            {
                result.ShouldEqual(true);
            };

            static IContainRequestInformation request;
            static bool result;
        }
    }
}