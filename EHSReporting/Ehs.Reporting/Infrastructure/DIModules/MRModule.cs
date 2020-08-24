using Autofac;
using Ehs.Reporting.MR.Models;
using Ehs.Reporting.MR.Repository;
using Ehs.Reporting.MR.Services;
using Ehs.Reporting.MR.Services.Interface;
using Ehs.Reporting.MR.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static Ehs.Reporting.MR.AppArgs;

namespace Ehs.Reporting.MR.Infrastructure
{
    public class MRModule : Module
    {
        private readonly IConfiguration _config;
        public MRModule(IConfiguration config)
        {
            _config = config;

        }

        protected override void Load(ContainerBuilder builder)
        {
            RegisterConfiguration(builder);

            builder.RegisterType<GenerateAndSendMR>()
                .WithParameter(new TypedParameter(typeof(GenerateAndSendMROptions), null))
                .InstancePerDependency();

            builder.RegisterType<GenerateAndSendMRForClient>()
                .WithParameter(new TypedParameter(typeof(GenerateAndSendMRForClientOptions), null))
                .InstancePerDependency();

            builder.RegisterType<GenerateAndSendMRForClientUser>()
                .WithParameter(new TypedParameter(typeof(GenerateAndSendMRForClientUserOptions), null))
                .InstancePerDependency();

            builder.RegisterType<ClientRepository>()
               .As<IClientRepository>()
               .SingleInstance();

            builder.RegisterType<EmailService>()
                .As<IEmailService>()
                .SingleInstance();

            builder.RegisterType<ActiveClientsService>()
                .As<IActiveClientsService>()
                .SingleInstance();

            builder.RegisterType<MRContentService>()
                 .As<IMRContentService>()
                 .SingleInstance();

            builder.RegisterType<ApplicationService>()
                .As<IApplicationService>()
                .SingleInstance();
            
            //builder.RegisterType<HttpContextAccessor>()
            //.As<IHttpContextAccessor>()
            //.SingleInstance();

            RegisterDbContext(builder);
        }

        private void RegisterConfiguration(ContainerBuilder builder)
        {
            var mrSettings = new MRContentSettings();
            _config.Bind("MRContentProvider", mrSettings);

            builder.RegisterInstance(mrSettings).AsSelf();

            var emailSettings = new EmailSettings();
            _config.Bind("Email", emailSettings);

            builder.RegisterInstance(emailSettings).AsSelf();

            builder.RegisterInstance(_config);


        }

        private void RegisterDbContext(ContainerBuilder builder)
        {
            var connectionString = _config.GetConnectionString("EhsSqlContext");
            var dbContextBuilder = new DbContextOptionsBuilder<EhsSqlContext>()
                .UseSqlServer(connectionString);

            builder.RegisterInstance(new EhsSqlContext(dbContextBuilder.Options));

        }
    }
}
