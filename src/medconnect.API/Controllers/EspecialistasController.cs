using medconnect.API.Context;
using medconnect.API.Models;
using medconnect.API.Repository.interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Web;

namespace medconnect.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialistasController : ControllerBase
    {
        private readonly IUnitOfWork _context;
        private AppDbContext _appDbContext;
        public EspecialistasController(IUnitOfWork context, AppDbContext appDbContext) 
        {
            _context = context;
            _appDbContext = appDbContext;
        }

        [HttpGet]
        [HttpGet("especialistas")]
        public async Task<IEnumerable<Especialista>> Get()
        {
            var especialistas = await _context.EspecialistaRepository.GetEspecialistasAtendimentos();
            return especialistas;
        }

        [HttpGet("especialistasOnly")]
        public async Task<ActionResult<IEnumerable<Especialista>>> GetEsp()
        {
            var especialistas = await _context.EspecialistaRepository.GetAll().ToListAsync();

            return especialistas;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Especialista>> Get(string id)
        {
            string eId = System.Web.HttpUtility.UrlDecode(id);
            //Guid guid = new Guid(eId);         
            if (Guid.TryParse(eId, out Guid guid)) { 
                var especialista = await _context.EspecialistaRepository.GetById(e => e.EspecialistaId == guid);
                if (especialista is null)
                    return NotFound();
                return especialista;
            }
            return BadRequest("Especialista invalido...");          
        }

        [HttpGet("add")]
        public async Task<ActionResult<string>> Add()
        {
            string descricao = "Médico especialista que se dedica ao diagnóstico, tratamento, cuidado e encaminhamento para outras especialidades médicas, a partir de uma visão ampla sobre o paciente e sua condição clínica.\r\n\r\nÉ comumente confundido com o médico generalista, que é o termo usado para o profissional formado em Medicina, sem nenhuma especialidade, porém autorizado pelo CRM – Conselho Regional de Medicina para exercer a atividade. E ainda, com o médico da família, que fez especialização em MFC – Medicina da Família e Comunidade e é o único dos três que pode atender crianças e gestantes.";
          
            
            List<Especialista> es = new List<Especialista>() {
                new Especialista { 
                    Nome = "André", 
                    Sobrenome = "Silva", 
                    DescricaoCurta = "Médico especialista em cirurgia bariatrica.", 
                    FotoPerfil = "personImages/persona01.png", 
                    DescricaoDetalhada=descricao,
                    Especialidade = "Cirurgia Bariatrica",
                    ImagemsPublicidade = new List<ImagemPublicidade>
                                        {
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica1.png" },
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica2.png" },
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica3.png" },
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica4.png" },
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica5.png" },
                                        }
                
                },
              
                new Especialista { Nome = "João",
                    Sobrenome = "Gonsalves", 
                    DescricaoCurta = "Médico Especialista em Cirurgia Vascular. Cuida dos problemas em vasos sanguíneos das pernas, braços, tronco e pescoço. Problemas das artérias como aneurisma de aorta, estenose das carótidas, doença arterial obstrutiva; e nas veias: teleangectasias, varizes e trombos.  O cirurgião plástico atua na reparação de órgãos e tecidos para", 
                    FotoPerfil = "personImages/persona02.png",
                    DescricaoDetalhada=descricao,
                    Especialidade = "Cirurgião",
                    ImagemsPublicidade =  new List<ImagemPublicidade>
                                        {
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica1.png" },
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica2.png" },
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica3.png" },
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica4.png" },
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica5.png" },
                                        },
                },

                new Especialista { Nome = "Aline", 
                    Sobrenome = "Santos", 
                    DescricaoCurta = "Especialista em Dermatologia...", 
                    FotoPerfil = "personImages/persona03.png",
                    DescricaoDetalhada=descricao,
                    Especialidade = "Dermatologia",
                    ImagemsPublicidade =  new List<ImagemPublicidade>
                                        {
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica1.png" },
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica2.png" },
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica3.png" },
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica4.png" },
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica5.png" },
                                        },
                },

                new Especialista { Nome = "Maria Helena", 
                    Sobrenome = "Albuquerque", 
                    DescricaoCurta = "Especialista em Clínica Médica...",
                    FotoPerfil = "personImages/persona04.png",
                    DescricaoDetalhada=descricao,
                    Especialidade = "Clinica Geral",
                    ImagemsPublicidade =  new List<ImagemPublicidade>
                                        {
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica1.png" },
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica2.png" },
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica3.png" },
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica4.png" },
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica5.png" },
                                        },
                },

                new Especialista { Nome = "José",
                    Sobrenome = "Toledo Junior", 
                    DescricaoCurta = "Especialista em Endocrinologia e Metabologia...", 
                    FotoPerfil = "personImages/persona05.png",
                    DescricaoDetalhada=descricao,
                    Especialidade = "Endocrinologia",
                    ImagemsPublicidade =  new List<ImagemPublicidade>
                                        {
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica1.png" },
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica2.png" },
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica3.png" },
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica4.png" },
                                            new ImagemPublicidade { UrlImage = "publicidade/clinica5.png" },
                                        },
                },
        };
             _appDbContext.Especialistas.AddRangeAsync(es);
             await _appDbContext.SaveChangesAsync();

            return "criado";
        }

        [HttpGet("addAtende")]
        public async Task<ActionResult<string>> AddAtende()
        {
            List<Atendimento> at = new List<Atendimento>()
            {
                new Atendimento{ EspecialistaId = Guid.Parse("08dbf111-3aa5-40e0-855e-355d0ea5bcfb"), 
                    AtendimentoId = Guid.NewGuid(), DataAtendimento = new DateTime(2023, 12, 22, 15, 00, 0)
                },

               
                 new Atendimento{ EspecialistaId = Guid.Parse("08dbf111-3abc-47ea-8c52-02ea91e4381d"),
                    AtendimentoId = Guid.NewGuid(), DataAtendimento =  new DateTime(2023, 12, 25, 15, 30, 0)
                },

                 new Atendimento{ EspecialistaId = Guid.Parse("08dbf111-3abd-4051-8d6b-70f8116acd87"),
                    AtendimentoId = Guid.NewGuid(), DataAtendimento =  new DateTime(2023, 12, 23, 18, 00, 0)
                },

                new Atendimento{ EspecialistaId = Guid.Parse("08dbf111-3abd-40c7-8606-51cc8e8fc3c5"),
                    AtendimentoId = Guid.NewGuid(), DataAtendimento =  new DateTime(2023, 12, 18, 13, 30, 0)
                },

                 new Atendimento{ EspecialistaId = Guid.Parse("08dbf111-3abd-4152-8656-a4e7882e8a59"),
                    AtendimentoId = Guid.NewGuid(), DataAtendimento = new DateTime(2023, 12, 27, 18, 20, 0)
                },

            };
                        

            _appDbContext.Atendimentos.AddRangeAsync(at);
            await _appDbContext.SaveChangesAsync();

            return "criado";
        }
    }
}
