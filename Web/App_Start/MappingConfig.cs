using System.Collections.ObjectModel;
using System.Linq;
using AutoMapper;
using Core.DomainModel.Frontpage;
using Web;
using Web.Models.Post;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(MappingConfig), "Start")]

namespace Web
{
    public class MappingConfig
    {
        public static void Start()
        {
            Mapper.CreateMap<PostRevisionViewModel, PostRevision>().ReverseMap();

            Mapper.CreateMap<PostOutViewModel, Post>()
                .ReverseMap()
                .ForMember(model => model.Header,
                    expression => expression.MapFrom(post => post.Revisions.FirstOrDefault().Header))
                .ForMember(model => model.ModifiedOn,
                    expression => expression.MapFrom(post => post.Revisions.FirstOrDefault().ModifiedOn))
                .ForMember(model => model.Text,
                    expression => expression.MapFrom(post => post.Revisions.FirstOrDefault().Text));

            Mapper.CreateMap<PostInViewModel, Post>()
                .ForMember(post => post.Revisions, expression => expression.MapFrom(model =>
                    new Collection<PostRevision>
                    {
                        new PostRevision
                            {
                                Header = model.Header,
                                Text = model.Text,
                                ModifiedOn = model.ModifiedOn
                            }
                    }
                ))
                .ForMember(post => post.Id, expression => expression.Ignore())
                .ReverseMap();
        }
    }
}